using UnityEngine;

public class Dog_Movement : MonoBehaviour
{
    public float moveSpeed;
    
    void Start()
    {
        //Debug.Log($"���� z���� ���� {this.transform.position.z}");

        //this.transform.position = this.transform.position + Vector3.forward * moveSpeed;

        //Debug.Log($"���� z���� ���� {this.transform.position.z}");
    }

    
    void Update()
    {
       // this.transform.position = this.transform.position + Vector3.forward * moveSpeed;
       

        if (Input.GetKey(KeyCode.W)) // ������ ���� ���
        {
            transform.position += Vector3.forward * (moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S)) // �ڷ� ���� ���
        {
            transform.position += Vector3.back * (moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A)) // �������� ���� ���
        {
            transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D)) // ���������� ���� ���
        {
            transform.position += Vector3.right * (moveSpeed * Time.deltaTime);
        }

    }
}
