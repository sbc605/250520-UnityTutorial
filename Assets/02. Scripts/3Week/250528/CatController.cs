using UnityEngine;
using Cat;
using Unity.VisualScripting;
using cat;
using System.Collections; // ���� �Ŵ����� �ִ� namespace

public class CatController : MonoBehaviour
{
    public SoundManager soundManager; // ����Ƽ �󿡼� �Ҵ� ����
    public VideoManager videoManager;


    public GameObject gameOverUI;
    public GameObject fadeUI;
    public GameObject playUI;  


    Rigidbody2D catRb;
    Animator catAnim;
    public float jumpPower = 30f;
    public float limitPower = 19f;

    public int jumpCount = 0;

    void Awake()
    {
        catRb = GetComponent<Rigidbody2D>();
        catAnim = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        transform.localPosition = new Vector3(-7.52f, 0.72f, 0f);
        GetComponent<CircleCollider2D>().enabled = true;
        soundManager.audioSource.Play();
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
                fadeUI.GetComponent<FadePanel>().OnFade(2f, Color.white, true); // 2�� ���̵�
                GetComponent<CircleCollider2D>().enabled = false; // �ڽ��� �ݶ��̴� ���� ���

                // Invoke("HappyVideo", 4f);

                StartCoroutine(EndingRoutine(true));
                // EndingRoutine(true); < �������� �ڷ�ƾ�̶� ���� ���� ����(����ȵ�)
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

            gameOverUI.SetActive(true); // ���� ���� �ѱ�
            fadeUI.SetActive(true); // ���̵� �ѱ�
            fadeUI.GetComponent<FadePanel>().OnFade(2f, Color.black, true); // ���̵� ����
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

    IEnumerator EndingRoutine(bool isHappy) // ���� ���̵� ��
    {
        yield return new WaitForSeconds(2.5f); // ���̵� �� 2.5f ���   
        
        videoManager.VideoPlay(isHappy); // ���� ��� ����
        yield return new WaitForSeconds(1f); // 1�� ���

        soundManager.audioSource.Stop();
        var newColor = isHappy ? Color.white : Color.black; // ���̵带 ������ ǰ
        fadeUI.GetComponent<FadePanel>().OnFade(2f, newColor, false); // ���̵带 �� ����

        yield return new WaitForSeconds(2.5f);
        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);

        transform.parent.gameObject.SetActive(false); // PLAY �׷� Off
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
