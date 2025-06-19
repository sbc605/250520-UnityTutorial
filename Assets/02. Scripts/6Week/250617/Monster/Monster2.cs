using System.Collections;
using UnityEngine;

public abstract class Monster2 : MonoBehaviour
{
    private SpriteRenderer sRenderer;

    private Animator animator;
    private bool isMove = true;
    private bool isHit = false;

    [SerializeField] protected float hp = 3f;
    [SerializeField] protected float moveSpeed = 3f;

    private int dir = 1; // 방향값
    public int Dir
    {
        get { return dir; }
        set { dir = value; }
    }

    private SpawnManager spawner;


    public abstract void Init();

    void Awake()
    {
        spawner = FindFirstObjectByType<SpawnManager>();
        sRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        Init();        
    }

    void OnMouseDown() // 마우스 클릭했을 때 반응(유니티 제공 함수) 콜라이더 있어야함
    {
        // Hit(1);
        StartCoroutine(Hit(1));
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (!isMove)
            return;

        transform.position += Vector3.right * dir * moveSpeed * Time.deltaTime;

        if (transform.position.x > 8f)
        {
            dir = -1;
            sRenderer.flipX = true;
        }
        else if (transform.position.x < -8f)
        {
            dir = 1;
            sRenderer.flipX = false;
        }

        SetFlip(dir);
    }

    public void SetFlip(int dir)
    {
        if (dir > 0)
            sRenderer.flipX = false;
        else
            sRenderer.flipX = true;
    }

    public IEnumerator Hit(float damage)
    {
        if (isHit)
            yield break;

        isHit = true;
        isMove = false;        

        hp -= damage;

        if (hp <= 0)
        {
            animator.SetTrigger("Death");

            spawner.DropCoin(transform.position); // 코인 생성

            yield return new WaitForSeconds(3f);
            Destroy(gameObject);

            yield break;
        }

        animator.SetTrigger("Hit");

        yield return new WaitForSeconds(0.65f);
        isHit = false;
        isMove = true;
    }
}
