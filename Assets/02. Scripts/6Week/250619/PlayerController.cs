using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;

    [SerializeField] private GameObject hitBox;

    [SerializeField] private float moveSpeed = 3f;
    private float h, v;

    private bool isAttack = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Move();
        Attack();
    }

    void Move()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        // Idle 상태 > 움직이지 않는 상태
        if (h == 0 && v == 0)
        {
            animator.SetBool("Run", false);
        }

        // Run 상태 > 움직이는 상태(키 하나라도 누름)
        else
        {
            int scaleX = h > 0 ? 1 : -1;            
            transform.localScale = new Vector3(scaleX, 1, 1);

            animator.SetBool("Run", true);

            var dir = new Vector3(h, v, 0).normalized;
            transform.position += dir * moveSpeed * Time.deltaTime;
        }
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isAttack)
        {
            StartCoroutine(AttackRoutine());
        }
    }

    IEnumerator AttackRoutine()
    {
        //isAttack = true;
        hitBox.SetActive(true);

        yield return new WaitForSeconds(0.25f);
        hitBox.SetActive(false);
        //isAttack = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Monster2>() != null)
        {
            Monster2 monster = other.GetComponent<Monster2>();
            StartCoroutine(monster.Hit(1));
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<IItem>() != null)
        {
            IItem item = other.gameObject.GetComponent<IItem>();
            item.Get();
        }
    }
}
