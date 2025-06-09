using UnityEngine;
using Cat;
using Unity.VisualScripting; // ���� �Ŵ����� �ִ� namespace

public class CatController : MonoBehaviour
{
    public SoundManager soundManager; // ����Ƽ �󿡼� �Ҵ� ����

    Rigidbody2D catRb;
    Animator catAnim;
    public float jumpPower = 30f;
    public float limitPower = 19f;

    public bool isGround = false;
    public int jumpCount = 0;

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

            if (catRb.linearVelocityY > limitPower)
            catRb.linearVelocityY = limitPower;
        }

        var catRotation = transform.eulerAngles;
        catRotation.z = catRb.linearVelocity.y * 2.5f;
        transform.eulerAngles = catRotation;

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
