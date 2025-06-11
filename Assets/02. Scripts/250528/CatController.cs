using UnityEngine;
using Cat;
using Unity.VisualScripting;
using cat;
using System.Collections; // 사운드 매니저가 있는 namespace

public class CatController : MonoBehaviour
{
    public SoundManager soundManager; // 유니티 상에서 할당 예정
    public VideoManager videoManager;


    public GameObject gameOverUI;
    public GameObject fadeUI;
    public GameObject playUI;  


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

                // Invoke("HappyVideo", 4f);

                StartCoroutine(EndingRoutine(true));
                // EndingRoutine(true); < 오류지만 코루틴이라 에러 뜨지 않음(실행안됨)
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

            // Invoke("SadVideo", 4f);

            StartCoroutine(EndingRoutine(false));
        }

        if (other.gameObject.CompareTag("Ground"))
        {
            catAnim.SetBool("isGround", true);
            jumpCount = 0;
        }
    }

    IEnumerator EndingRoutine(bool isHappy)
    {
        yield return new WaitForSeconds(2.5f); // 뒤에 적힌 값만큼 대기
        videoManager.VideoPlay(isHappy);

        // yield return new WaitUntil(() => videoManager.vPlayer.isPlaying); // 뒤에 적힌 bool값이 true가 될 때까지 대기

        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);

        soundManager.audioSource.mute = true;
    }

    /*
    private void HappyVideo()
    {
        videoManager.VideoPlay(true);

        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);

        soundManager.audioSource.mute = true;
    }

    private void SadVideo()
    {
        videoManager.VideoPlay(false);

        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);

        soundManager.audioSource.mute = true;
    }
    */
}
