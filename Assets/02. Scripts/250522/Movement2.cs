using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Movement2 : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        //// �� �������� ��(������ 1, -1)
        //float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");
        
        // �ε巴�� �����ϴ� ��(�ڿ����������̰�)
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        Vector3 normalDir = dir.normalized;

        transform.position += normalDir * moveSpeed * Time.deltaTime;

        transform.LookAt(transform.position + normalDir);


        //Vector3 normalDir = dir.normalized;

        //Debug.Log($"���� �Է� : {normalDir}");

        //transform.position += normalDir * moveSpeed * Time.deltaTime;
    }
}
