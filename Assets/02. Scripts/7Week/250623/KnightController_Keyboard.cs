using UnityEngine;

public class KnightController_Keyboard : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D knightRb;

    private Vector3 inputDir;
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float jumpPower = 30f;
    private bool isGround = true;

    void Start()
    {
        animator = GetComponent<Animator>();
        knightRb = GetComponent<Rigidbody2D>();
    }

    void Update() // �Ϲ����� �۾�
    {
        InputKeyboard();
    }

    void FixedUpdate() // �������� �۾�
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

    void InputKeyboard()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        inputDir = new Vector3(h, v, 0);

        Jump();
        SetAnimation();
    }

    void Move()
    {
        if (inputDir.x != 0)
        {
            knightRb.linearVelocityX = inputDir.x * moveSpeed;
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

    void SetAnimation()
    {
        if (inputDir.x != 0)
        {
            animator.SetBool("isRun", true);

            var scaleX = inputDir.x > 0 ? 1 : -1;
            transform.localScale = new Vector3(scaleX, 1, 1);
        }
        else if (inputDir.x == 0)
        {
            animator.SetBool("isRun", false);
        }
    }
}
