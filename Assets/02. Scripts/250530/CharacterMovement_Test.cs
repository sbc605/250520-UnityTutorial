using UnityEngine;

public class CharacterMovement_Test : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float jumpPower = 5f;
    [SerializeField] private int playerMaxJump = 3;
    [SerializeField] private int jumpCount;
    [SerializeField] private bool isGround;
    [SerializeField] private bool isLeft;
    private SpriteRenderer[] renderers;
    private Rigidbody2D SpriteRb;
    private float h;

    private void Start()
    {
        SpriteRb = GetComponent<Rigidbody2D>();
        renderers = GetComponentsInChildren<SpriteRenderer>();
        Time.fixedDeltaTime = 0.01f;
        jumpCount = playerMaxJump;
    }

    private void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        if (h < 0 && h != 0) isLeft = true;
        else if (h > 0 && h != 0) isLeft = false;

        OnSprite();
        PlayerJump();
    }

    private void FixedUpdate()
    {
        PlayerMove();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
            jumpCount = 0;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGround = false;
    }

    private void PlayerMove()
    {
        SpriteRb.linearVelocityX = h * moveSpeed;
    }

    private void OnSprite()
    {
        renderers[0].gameObject.SetActive(h == 0 && isGround);
        renderers[1].gameObject.SetActive(h != 0 && isGround);
        renderers[2].gameObject.SetActive(!isGround);

        foreach (SpriteRenderer r in renderers)
        {
            r.flipX = isLeft;
        }
    }

    private void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && jumpCount < playerMaxJump)
        {
            SpriteRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++;
        }
    }

}
