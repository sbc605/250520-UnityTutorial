using UnityEngine;

public class StudyTransform : MonoBehaviour
{

    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;
           
    void Update()
    {
        //// 월드 방향으로 이동하는 기능
        // transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);


        //// 로컬 방향으로 이동하는 기능
        //// transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        ////월드 방향으로 회전
        ////float angle = transform.eulerAngles.y + rotateSpeed * Time.deltaTime;
        ////float localX = transform.eulerAngles.x;
        ////float localZ = transform.eulerAngles.z;
        ////transform.rotation = Quaternion.Euler(localX, angle, localZ);

        //// 월드 방향으로 회전
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

        ////로컬 방향으로 회전
        //// transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Self 생략

        // 특정 위치의 주변을 회전
        transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);

        //특정 위치를 바라보며 회전
        transform.LookAt(Vector3.zero); 



    }
}
