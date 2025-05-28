using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 3f;

    public Rigidbody2D carRb; // GetComponent<Rigidbody2D> �� ������ ��

    private float h; // ��������� Ŭ������ �ִ� ��� scope�� ���ٰ���

    void Update()
    {
        h = Input.GetAxis("Horizontal"); // ����(x��)

        // Transform �̵�
        // transform.position += Vector3.right * h * (moveSpeed * Time.deltaTime);

        // Debug.Log("Update");
    }

    void FixedUpdate()
    {
        // Rigidbody�� �ӵ��� Ȱ���� �̵�
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


