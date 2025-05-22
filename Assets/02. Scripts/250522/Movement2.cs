using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Movement2 : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        //// �ε巴�� �����ϴ� ��(�ڿ����������̰�)
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        // �� �������� ��(������ 1, -1)
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");


        Vector3 dir = new Vector3(h, 0, v);
        Debug.Log($"���� �Է� : {dir}");

        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}

//if (Input.GetKey(KeyCode.W)) // ������ ���� ���
//{
//    transform.position += Vector3.forward * (moveSpeed * Time.deltaTime);
//}

//if (Input.GetKey(KeyCode.S)) // �ڷ� ���� ���
//{
//    transform.position += Vector3.back * (moveSpeed * Time.deltaTime);
//}

//if (Input.GetKey(KeyCode.A)) // �������� ���� ���
//{
//    transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
//}

//if (Input.GetKey(KeyCode.D)) // ���������� ���� ���
//{
//    transform.position += Vector3.right * (moveSpeed * Time.deltaTime);
//}
