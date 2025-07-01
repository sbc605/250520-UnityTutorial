using UnityEngine;

public abstract class MonsterCore : MonoBehaviour
{
    public enum MonsterState { Idle, Patrol, Trace, Attack }
    [SerializeField] private MonsterState monsterState;

    public float hp, speed, attackTime;
    protected float moveDir;
    protected float targetDist;
    protected bool isTrace;    

    protected Animator animator;
    protected Rigidbody2D monsterRb;
    protected Collider2D monsterColl;

    public Transform target;

    protected virtual void Init(float hp, float speed, float attackTime)
    {
        this.hp = hp;
        this.speed = speed;
        this.attackTime = attackTime;

        target = FindFirstObjectByType<KnightController_Keyboard>().transform;


        animator = GetComponent<Animator>();
        monsterRb = GetComponent<Rigidbody2D>();
        monsterColl = GetComponent<Collider2D>();
    }

    void Update()
    {
        targetDist = Vector3.Distance(transform.position, target.position);

        Vector3 monsterDir = Vector3.right * moveDir; // ���� ���Ͱ� �ٶ󺸴� ����(�̵��Ϸ��� ������ ��� �ٶ�)

        Vector3 playerDir = (transform.position - target.position).normalized; // �÷��̾ ���͸� �ٶ󺸴� ����(����(������) - �÷��̾�) // target�� �÷��̾�

        float dotValue = Vector3.Dot(monsterDir, playerDir); // ���ֺ� ����

        isTrace = dotValue < 0f;


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
}
