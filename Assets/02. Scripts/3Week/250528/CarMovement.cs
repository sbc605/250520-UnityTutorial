using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 3f;

    public Rigidbody2D carRb; // GetComponent<Rigidbody2D> 에 접근한 것

    private float h; // 멤버변수는 클래스에 있는 모든 scope에 접근가능

    void Update()
    {
        h = Input.GetAxis("Horizontal"); // 수평값(x값)

        // Transform 이동
        // transform.position += Vector3.right * h * (moveSpeed * Time.deltaTime);

        // Debug.Log("Update");
    }

    void FixedUpdate()
    {
        // Rigidbody의 속도를 활용한 이동
        carRb.linearVelocityX = h * moveSpeed;
        // Debug.Log("FixedUpdate");
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // other.gameObject.SetActive(false);
        Debug.Log("Collision Enter");
    }

    void OnCollisionStay2D(Collision2D other)
    {
        // other.gameObject.SetActive(false);
        Debug.Log("Collision Stay");
    }

    void OnCollisionExit2D(Collision2D other)
    {
        // other.gameObject.SetActive(false);
        Debug.Log("Collision Exit");
    }

    void OnTriggerEnter2D(Collider2D other)
    {  
        Debug.Log("Trigger Enter");
    }    
    void OnTriggerStay2D(Collider2D other)
    {      
        Debug.Log("Trigger Stay");
    }    
    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Trigger Exit");
    }
}


