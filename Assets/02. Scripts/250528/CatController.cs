using UnityEngine;
using Cat;
using Unity.VisualScripting; // 사운드 매니저가 있는 namespace

public class CatController : MonoBehaviour
{
    public SoundManager soundManager; // 유니티 상에서 할당 예정

    public GameObject gameOverUI;
    public GameObject fadeUI;
    public GameObject playUI;

    public GameObject happyVideo;
    public GameObject sadVideo;


    Rigidbody2D catRb;
    Animator catAnim;
    public float jumpPower = 30f;
    public float limitPower = 19f;

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
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 10)
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            other.gameObject.SetActive(false);
            // other.transform.parent.GetComponent<ItemEvent>().particle.SetActive(true);
            other.GetComponentInParent<ItemEvent>().particle.SetActive(true);

            GameManager.score++;

            if (GameManager.score == 10)
            {
                fadeUI.SetActive(true);
                fadeUI.GetComponent<FadePanel>().OnFade(2f, Color.white);
                GetComponent<CircleCollider2D>().enabled = false; // 자신의 콜라이더 끄는 기능

                Invoke("HappyVideo", 4f);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Pipe"))
        {
            soundManager.OnColliderSound();
            // Fade || Outro || Game End UI
            Debug.Log("Game Over");

            gameOverUI.SetActive(true); // 게임 오버 켜기
            fadeUI.SetActive(true); // 페이드 켜기
            fadeUI.GetComponent<FadePanel>().OnFade(2f, Color.black); // 페이드 실행
            GetComponent<CircleCollider2D>().enabled = false;

            Invoke("SadVideo", 4f);
        }

        if (other.gameObject.CompareTag("Ground"))
        {
            catAnim.SetBool("isGround", true);
            jumpCount = 0;
        }
    }

    private void HappyVideo()
    {
        happyVideo.SetActive(true);
        fadeUI.SetActive(false);
        playUI.SetActive(false);
        gameOverUI.SetActive(false);

        soundManager.audioSource.mute = true;
    }

    private void SadVideo()
    {
        sadVideo.SetActive(true);
        fadeUI.SetActive(false);
        playUI.SetActive(false);
        gameOverUI.SetActive(false);

        soundManager.audioSource.mute = true;
    }

}
