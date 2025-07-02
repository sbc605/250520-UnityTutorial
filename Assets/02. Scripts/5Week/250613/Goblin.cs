using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;
using static MonsterCore;

public class Goblin : MonsterCore
{
    private float timer;
    private float idleTime, patrolTime;
    private float traceDist = 5f; // 추격거리
    private float attackDist = 1.5f; // 공격거리

    private bool isAttack;     
      

    private void Start()
    {
        Init(30f, 2f, 2f, 10f);

        StartCoroutine(FindPlayerRoutine());
    }

    protected override void Init(float hp, float speed, float attackTime, float atkDamage)
    {
        base.Init(hp, speed, attackTime, atkDamage);

        idleTime = Random.Range(1f, 5f);       
    }

    IEnumerator FindPlayerRoutine()
    {
        while (true)
        {
            yield return null;
            targetDist = Vector3.Distance(transform.position, target.position);

            if (monsterState == MonsterState.Idle || monsterState == MonsterState.Patrol)
            {
                Vector3 monsterDir = Vector3.right * moveDir;
                Vector3 playerDir = (transform.position - target.position).normalized;
                float dotValue = Vector3.Dot(monsterDir, playerDir);
                isTrace = dotValue < -0.5f && dotValue >= -1f;

                if (targetDist <= traceDist && isTrace)
                {
                    animator.SetBool("isRun", true);

                    ChangeState(MonsterState.Trace);
                }
            }
            else if (monsterState == MonsterState.Trace)
            {
                if (targetDist > traceDist)
                {
                    timer = 0f;
                    idleTime = Random.Range(1f, 5f);
                    animator.SetBool("isRun", false);

                    ChangeState(MonsterState.Idle);
                }

                if (targetDist < attackDist)
                {
                    ChangeState(MonsterState.Attack);
                }
            }
        }
    }

    public override void Idle()
    {
        timer += Time.deltaTime;

        if (timer >= idleTime)
        {
            timer = 0f;
            moveDir = Random.Range(0, 2) == 1 ? 1 : -1;
            transform.localScale = new Vector3(moveDir, 1, 1);
            hpBar.transform.localScale = new Vector3(moveDir, 1, 1);

            animator.SetBool("isRun", true);
            patrolTime = Random.Range(1f, 5f);

            ChangeState(MonsterState.Patrol);
        }
    }

    public override void Patrol()
    {
        transform.position += Vector3.right * moveDir * speed * Time.deltaTime;

        timer += Time.deltaTime;
        if (timer >= patrolTime)
        {
            timer = 0f;

            idleTime = Random.Range(1f, 5f);

            animator.SetBool("isRun", false);

            ChangeState(MonsterState.Idle);
        }
    }

    public override void Trace()
    {
        var targetDir = (target.position - transform.position).normalized;
        transform.position += Vector3.right * targetDir.x * speed * Time.deltaTime;

        var scaleX = targetDir.x > 0 ? 1 : -1;
        transform.localScale = new Vector3(scaleX, 1, 1);     
        hpBar.transform.localScale = new Vector3(scaleX, 1, 1);
    }

    public override void Attack()
    {
        if (!isAttack)
            StartCoroutine(AttackRoutine());
    }

    IEnumerator AttackRoutine()
    {
        isAttack = true;
        animator.SetTrigger("Attack");
        yield return new WaitForSeconds(1f);
        
        animator.SetBool("isRun", false);
        var targetDir = (target.position - transform.position).normalized;
        var scaleX = targetDir.x > 0 ? 1 : -1;
        transform.localScale = new Vector3(scaleX, 1, 1);
        hpBar.transform.localScale = new Vector3(scaleX, 1, 1);
        yield return new WaitForSeconds(attackTime - 1f);
        
        isAttack = false;
        animator.SetBool("isRun", true);
        ChangeState(MonsterState.Trace);
    }
}
