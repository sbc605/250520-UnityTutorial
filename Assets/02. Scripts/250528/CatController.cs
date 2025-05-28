using UnityEngine;

public class CatController : MonoBehaviour
{
    Rigidbody2D catRb;
    public float jumpPower = 10f;

    public bool isGround = false;
    public int jumpCount = 0;

    void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        // 스페이스 키 입력
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 2)
        {
          catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
          jumpCount++;

        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
         jumpCount = 0;
         isGround = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
         isGround = false;
        }
        
    }
}
