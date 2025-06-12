using UnityEngine;

public class StudyTransform : MonoBehaviour
{

    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;
           
    void Update()
    {
        //// ���� �������� �̵��ϴ� ���
        // transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);


        //// ���� �������� �̵��ϴ� ���
        //// transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        ////���� �������� ȸ��
        ////float angle = transform.eulerAngles.y + rotateSpeed * Time.deltaTime;
        ////float localX = transform.eulerAngles.x;
        ////float localZ = transform.eulerAngles.z;
        ////transform.rotation = Quaternion.Euler(localX, angle, localZ);

        //// ���� �������� ȸ��
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

        ////���� �������� ȸ��
        //// transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Self ����

        // Ư�� ��ġ�� �ֺ��� ȸ��
        transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);

        //Ư�� ��ġ�� �ٶ󺸸� ȸ��
        transform.LookAt(Vector3.zero); 



    }
}
