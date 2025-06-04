using UnityEngine;
using Cat; // ���� �Ŵ����� �ִ� namespace

public class CatController : MonoBehaviour
{
    public SoundManager soundManager; // ����Ƽ �󿡼� �Ҵ� ����

    Rigidbody2D catRb;
    Animator catAnim;
    public float jumpPower = 10f;

    public bool isGround = false;
    public int jumpCount = 0;
    /// �ڿ������� ������ ���� �ӵ� ����
    /// public float limitPower = 7f;

    void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
        catAnim = GetComponent<Animator>();
        
    }

    void Update()
    {
        Jump();
    }

    void Jump()
    {
        // �����̽� Ű �Է�
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 2)
        {
          catAnim.SetTrigger("Jump");
          catAnim.SetBool("isGround", false);

            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
          jumpCount++;

            soundManager.OnJumpSound();
        }

        /* �ڿ������� ������ ���� �ӵ� ����
        if (catRb.linearVelocityY > limitPower) 
        {
            catRb.linearVelocityY = limitPower;
        }
        */
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
         jumpCount = 0;
         //isGround = true;
         catAnim.SetBool("isGround", true);
        }
    }

    //void OnCollisionExit2D(Collision2D other)
    //{
    //    if (other.gameObject.CompareTag("Ground"))
    //    {
    //     isGround = false;
    //    }        
    //}
}
