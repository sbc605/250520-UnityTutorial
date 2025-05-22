using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Movement2 : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        //// 부드럽게 증감하는 값(자연스러워보이게)
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        // 딱 떨어지는 값(누르면 1, -1)
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");


        Vector3 dir = new Vector3(h, 0, v);
        Debug.Log($"현재 입력 : {dir}");

        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}

//if (Input.GetKey(KeyCode.W)) // 앞으로 가는 기능
//{
//    transform.position += Vector3.forward * (moveSpeed * Time.deltaTime);
//}

//if (Input.GetKey(KeyCode.S)) // 뒤로 가는 기능
//{
//    transform.position += Vector3.back * (moveSpeed * Time.deltaTime);
//}

//if (Input.GetKey(KeyCode.A)) // 왼쪽으로 가는 기능
//{
//    transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
//}

//if (Input.GetKey(KeyCode.D)) // 오른쪽으로 가는 기능
//{
//    transform.position += Vector3.right * (moveSpeed * Time.deltaTime);
//}
