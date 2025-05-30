using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D characterRb;
    public SpriteRenderer[] renderers;

    public float moveSpeed;
    public float jumpPower = 10f;
    private float h;

    public bool isGround;
    private int jumpCount;

    private void Start()
    {
        characterRb = GetComponent<Rigidbody2D>();

        renderers = GetComponentsInChildren<SpriteRenderer>(true);
    }

    private void Update()
    {
        h = Input.GetAxisRaw("Horizontal");

        Jump();

    }

        /* 트랜스폼 이동
        transform.position ~
        transform.Translate (~)
       */

    private void FixedUpdate()
    {
        Move();       
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {

        isGround = true;
        jumpCount = 0;

        renderers[2].gameObject.SetActive(false); // 한번 실행되는거라 여기에

        }        
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
        isGround = false;
        
        renderers[0].gameObject.SetActive(false); // Idle
        renderers[1].gameObject.SetActive(false); // Run
        renderers[2].gameObject.SetActive(true);
        }
    }

    /// <summary>
    /// 캐릭터 움직임에 따라 이미지의 Flip 상태가 변하는 코드
    /// </summary>
    void Move()  
    {

        if (!isGround)
            return;

        if (h != 0) // 움직일 때(입력 키를 누를 때)
        {
            renderers[0].gameObject.SetActive(false); // Idle
            renderers[1].gameObject.SetActive(true); // Run

            characterRb.linearVelocityX = h * moveSpeed; // 물리적인 이동(리지드바디)

            if (h > 0) // h가 +일 때
            {
                renderers[0].flipX = false;
                renderers[1].flipX = false;
                renderers[2].flipX = false;
            }

            else if (h < 0) // h가 -일 때
            {
                renderers[0].flipX = true;
                renderers[1].flipX = true;
                renderers[2].flipX = true;

            }
        }

        else // 안 움직일 때(키를 안 누를 때)
        {
            renderers[0].gameObject.SetActive(true); // Idle
            renderers[1].gameObject.SetActive(false); // Run
        }

        //// Character Set Active
        //renderers[0].gameObject.SetActive(h == 0);
        //renderers[1].gameObject.SetActive(h != 0);



    }

    /// <summary>
    /// 캐릭터가 +Y 방향으로 점프하는 기능
    /// </summary>
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && jumpCount < 2) // Input.GetKeyDown(KeyCode.Spac)
        {
            characterRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            // characterRb.AddForce(Vector3.up * jumpPower, ForceMode2D.Impulse);

            jumpCount++;

            renderers[2].gameObject.SetActive(true); // Jump                       
            

        }
    }
}

