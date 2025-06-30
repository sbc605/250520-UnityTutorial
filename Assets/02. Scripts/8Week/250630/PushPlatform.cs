using UnityEngine;

public class PushPlatform : MonoBehaviour
{
    private Animator ani;
    private Rigidbody2D targetRb;
    [SerializeField] private float pushPower = 50f;

    void Start()
    {
        ani = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            targetRb = other.GetComponent<Rigidbody2D>();

            Invoke("PushCharacter", 1f);
        }
    }

    void PushCharacter()
    {
        targetRb.AddForceY(pushPower, ForceMode2D.Impulse);
        ani.SetTrigger("Push");
    }
}
