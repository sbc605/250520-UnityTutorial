using UnityEngine;
using UnityEngine.UI;

public class KnightController_Joystick : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D knightRb;

    // [SerializeField] private Button jumpButton;
    // [SerializeField] private Button attackButton;

    private Vector3 inputDir;
    [SerializeField] private float moveSpeed = 3f;
    // [SerializeField] private float jumpPower = 30f;
    // private bool isGround, isCombo, isAttack;
    // float atkDamage = 3f;

    void Start()
    {
        animator = GetComponent<Animator>();
        knightRb = GetComponent<Rigidbody2D>();

        /*
        jumpButton.onClick.AddListener(Jump);
        attackButton.onClick.AddListener(Attack); */
    }

    void FixedUpdate() // �������� �۾�
    {
        Move();
    }


    public void InputJoystick(float x, float y)
    {
        inputDir = new Vector3(x, y, 0).normalized;

        animator.SetFloat("JoystickX", inputDir.x);
        animator.SetFloat("JoystickY", inputDir.y);
    }


    void Move()
    {
        if (inputDir.x != 0)
        {
            var scaleX = inputDir.x > 0 ? 1 : -1;
            transform.localScale = new Vector3(scaleX, 1, 1);

            knightRb.linearVelocity = inputDir * moveSpeed;
        }
    }
    /*
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
        if (other.CompareTag("Monster"))
        {
            Debug.Log($"{atkDamage}�� ����");
        }
    } */

    /*
    void Jump()
    {
        if (isGround)
        {
            animator.SetTrigger("Jump");
            knightRb.AddForceY(jumpPower, ForceMode2D.Impulse);
        }
    }

    void Attack()
    {
        if (!isAttack) // �⺻���� false���� �̰� �����
        {
            isAttack = true;
            atkDamage = 3f;
            animator.SetTrigger("Attack");
        }
        else
        {
            isCombo = true; // ���� �޺��� �Ұ��� Ȯ���ϴ� �뵵
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
    } */

    /* ��� ����
    void Attack()
    {
        if (!isAttack) // �⺻���� false���� �̰� �����
        {
            isAttack = true;
            animator.SetTrigger("Attack");
        }
        else
        {
            animator.SetBool("isCombo", true);
        }
    }

    public void CheckCombo()
    {
        if (!animator.GetBool("isCombo"))
            isAttack = false;
    }

    public void EndCombo()
    {
        isAttack = false;
        animator.SetBool("isCombo", false);
    } */
}
