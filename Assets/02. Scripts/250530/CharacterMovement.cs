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

        /* Ʈ������ �̵�
        transform.position ~
        transform.Translate (~)
    }   */

    private void FixedUpdate()
    {
        Move();       
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        isGround = true;

        renderers[2].gameObject.SetActive(false);
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        isGround = false;

        renderers[0].gameObject.SetActive(false); // Idle
        renderers[1].gameObject.SetActive(false); // Run
        renderers[2].gameObject.SetActive(true);
    }

    /// <summary>
    /// ĳ���� �����ӿ� ���� �̹����� Flip ���°� ���ϴ� �ڵ�
    /// </summary>
    void Move()
    {

        if (!isGround)
            return;

        if (h != 0) // ������ ��(�Է� Ű�� ���� ��)
        {
            renderers[0].gameObject.SetActive(false); // Idle
            renderers[1].gameObject.SetActive(true); // Run

            characterRb.linearVelocityX = h * moveSpeed; // �������� �̵�(������ٵ�)

            if (h > 0) // h�� +�� ��
            {
                renderers[0].flipX = false;
                renderers[1].flipX = false;
                renderers[2].flipX = false;
            }

            else if (h < 0) // h�� -�� ��
            {
                renderers[0].flipX = true;
                renderers[1].flipX = true;
                renderers[2].flipX = true;

            }
        }

        else // �� ������ ��(Ű�� �� ���� ��)
        {
            renderers[0].gameObject.SetActive(true); // Idle
            renderers[1].gameObject.SetActive(false); // Run
        }

        //// Character Set Active
        //renderers[0].gameObject.SetActive(h == 0);
        //renderers[1].gameObject.SetActive(h != 0);



    }

    /// <summary>
    /// ĳ���Ͱ� +Y �������� �����ϴ� ���
    /// </summary>
    void Jump()
    {
        if (Input.GetButtonDown("Jump")) // Input.GetKeyDown(KeyCode.Spac)
        {
            characterRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            // characterRb.AddForce(Vector3.up * jumpPower, ForceMode2D.Impulse);

            renderers[2].gameObject.SetActive(true); // Jump
        }
    }
}

