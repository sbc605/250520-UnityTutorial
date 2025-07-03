using UnityEngine;
using UnityEngine.UI;

public abstract class MonsterCore : MonoBehaviour, IDamageable
{
    public enum MonsterState { Idle, Patrol, Trace, Attack }
    public MonsterState monsterState;

    public float hp, speed, attackTime;
    protected float moveDir;
    protected float targetDist;

    public float atkDamage;

    protected Animator animator;
    protected Rigidbody2D monsterRb;
    protected Collider2D monsterColl;
    public Image hpBar;
    public ItemManager itemManager;

    public Transform target;

    protected bool isTrace;
    protected bool isDead;

    protected float currHp;

    protected virtual void Init(float hp, float speed, float attackTime, float atkDamage)
    {
        this.hp = hp;
        this.speed = speed;
        this.attackTime = attackTime;
        this.atkDamage = atkDamage;

        currHp = hp;
        hpBar.fillAmount = currHp / hp;

        target = FindFirstObjectByType<KnightController_Keyboard>().transform;

        animator = GetComponent<Animator>();
        monsterRb = GetComponent<Rigidbody2D>();
        monsterColl = GetComponent<Collider2D>();

        itemManager = FindFirstObjectByType<ItemManager>();
    }

    void Update()
    {
        if (isDead)
            return;

        switch (monsterState)
        {
            case MonsterState.Idle:
                Idle();
                break;
            case MonsterState.Patrol:
                Patrol();
                break;
            case MonsterState.Trace:
                Trace();
                break;
            case MonsterState.Attack:
                Attack();
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Return"))
        {
            moveDir *= -1;
            transform.localScale = new Vector3(moveDir, 1, 1);
        }

        if (other.GetComponent<IDamageable>() != null)
        {
            other.GetComponent<IDamageable>().TakeDamage(atkDamage);
        }
    }

    public abstract void Idle();
    public abstract void Patrol();
    public abstract void Trace();
    public abstract void Attack();

    public void ChangeState(MonsterState newState)
    {
        if (monsterState != newState) // ���� �����ϴ� State�� �ٸ� ���
            monsterState = newState;
    }



    public void TakeDamage(float damage)
    {
        currHp -= damage;
        hpBar.fillAmount = currHp / hp; // ���� ü�� / �ִ� ü��

        if (currHp <= 0f)
        {
            Death();
        }
    }

    public void Death()
    {
        isDead = true;
        animator.SetTrigger("Death");
        monsterColl.enabled = false;
        monsterRb.gravityScale = 0f;

        int itemCount = Random.Range(0, 3); // �ִ� 2������ ����߸� �� �ִ�.

        if (itemCount > 0) // ����ó��
        {
            for (int i = 0; i < itemCount; i++) // 0���� ���� �� �־ ������ �� �� ����
            {
                itemManager.DropItem(transform.position); // �������� ������ ��ġ
            }
        }               
    }
}
