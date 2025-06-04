using UnityEngine;
using Cat; // 사운드 매니저가 있는 namespace

public class CatController : MonoBehaviour
{
    public SoundManager soundManager; // 유니티 상에서 할당 예정

    Rigidbody2D catRb;
    Animator catAnim;
    public float jumpPower = 10f;

    public bool isGround = false;
    public int jumpCount = 0;
    /// 자연스러운 점프를 위한 속도 제한
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
        // 스페이스 키 입력
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 2)
        {
          catAnim.SetTrigger("Jump");
          catAnim.SetBool("isGround", false);

            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
          jumpCount++;

            soundManager.OnJumpSound();
        }

        /* 자연스러운 점프를 위한 속도 제한
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
