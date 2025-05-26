using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf; // 바라봐야하기 때문에 target이라는 변수 잡아야함
    public Transform turretHead;


    public GameObject bulletPrefab; // 총알 프리팹
    public Transform firePos; // 발사 위치

    public float timer;
    public float cooldownTime;


    void Start() // 1번 실행 > 무엇인가를 셋팅하는 기능
  
    {
        GameObject target = GameObject.FindGameObjectWithTag("Player");

        turretHead = transform.GetChild(0);
        targetTf = target.transform; // 플레이어태그 캐릭터를 찾아서 타겟에 넣음       
    }

    void Update() // 무엇인가를 바라보는 기능
    {

       turretHead.LookAt(targetTf); // 터렛헤드가 타겟을 바라봄

        timer += Time.deltaTime;
        if (timer >= cooldownTime)
        {
            timer = 0;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation); // 총알 생성(총알 데이터, 위치, 회전값)

        }

    }
}
