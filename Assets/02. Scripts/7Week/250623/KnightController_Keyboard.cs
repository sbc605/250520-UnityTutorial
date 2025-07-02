using UnityEngine;
using UnityEngine.UI;

public class KnightController_Keyboard : MonoBehaviour, IDamageable
{
    private Animator animator;
    private Rigidbody2D knightRb;
    private Collider2D knightColl;
    public Image hpBar;

    public Vector3 inputDir;
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float jumpPower = 30f;
    
    private bool isGround, isCombo, isAttack, isLadder;
    private float atkDamage = 3f;
    public float maxHP = 100f;
    public float currHp;

    void Start()
    {
        animator = GetComponent<Animator>();
        knightRb = GetComponent<Rigidbody2D>();
        knightColl = GetComponent<Collider2D>();

        currHp = maxHP;
        hpBar.fillAmount = currHp / maxHP;
    }

    void Update() // 일반적인 작업
    {
        InputKeyboard();
        Jump();
        Attack();
    }

    void FixedUpdate() // 물리적인 작업
    {
        Move();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isGround", true);
            isGround = true;
        }        
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isGround", false);
            isGround = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Monster"))
        {
            if (other.GetComponent<IDamageable>() != null)
            {
                other.GetComponent<IDamageable>().TakeDamage(atkDamage);
                other.GetComponent<Animator>().SetTrigger("Hit");
            }
        }

            if (other.gameObject.CompareTag("Ladder"))
        {
            isLadder = true;
            knightRb.gravityScale = 0f;
            knightRb.linearVelocity = Vector2.zero;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ladder"))
        {
            isLadder = false;
            knightRb.gravityScale = 3f;
            knightRb.linearVelocity = Vector2.zero;
        }
    }

    void InputKeyboard()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        inputDir = new Vector3(h, v, 0);

        animator.SetFloat("JoystickX", inputDir.x);
        animator.SetFloat("JoystickY", inputDir.y);

        if (inputDir.y < 0) // 숙였을 때
        {
            GetComponent<CapsuleCollider2D>().size = new Vector2(0.7f, 0.3f);
            GetComponent<CapsuleCollider2D>().offset = new Vector2(0, 0.4f);
        }
        else // 서있을 때
        {
            GetComponent<CapsuleCollider2D>().size = new Vector2(0.7f, 1.7f);
            GetComponent<CapsuleCollider2D>().offset = new Vector2(0, 0.9f);
        }
    }

    void Move()
    {
        if (inputDir.x != 0)
        {
            var scaleX = inputDir.x > 0 ? 1 : -1;
            transform.localScale = new Vector3(scaleX, 1, 1);

            knightRb.linearVelocityX = inputDir.x * moveSpeed;
        }

        // Clime
        if (isLadder && inputDir.y != 0)
        {
            knightRb.linearVelocityY = inputDir.y * moveSpeed;
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            animator.SetTrigger("Jump");
            knightRb.AddForceY(jumpPower, ForceMode2D.Impulse);
        }
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (!isAttack) // 기본값이 false여서 이게 실행됨
            {
                isAttack = true;
                atkDamage = 3f;
                animator.SetTrigger("Attack");
            }
            else
            {
                isCombo = true; // 연속 콤보를 할건지 확인하는 용도
            }
        }

    }

    public void WaitCombo()
    {
        if (isCombo)
        {
            atkDamage = 5f;
            animator.SetBool("isCombo", true);
        }

        else
        {
            animator.SetBool("isCombo", false);
            isAttack = false;
        }
    }

    public void EndCombo()
    {
        isAttack = false;
        isCombo = false;
    }

    public void TakeDamage(float damage)
    {
        currHp -= damage;
        hpBar.fillAmount = currHp / maxHP; // 현재 체력 / 최대 체력

        if (currHp <= 0f)
        {
            Death();
        }        
    }

    public void Death()
    {
        animator.SetTrigger("Death");
        knightColl.enabled = false;
        knightRb.gravityScale = 0f;
    }
}
