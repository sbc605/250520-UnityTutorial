using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf; // �ٶ�����ϱ� ������ target�̶�� ���� ��ƾ���
    public Transform turretHead;

    public GameObject bulletPrefab; // �Ѿ� ������
    public Transform firePos; // �߻� ��ġ

    public float timer;
    public float cooldownTime;


    void Start() // 1�� ���� > �����ΰ��� �����ϴ� ���
    {
        turretHead = transform.GetChild(0);
        targetTf = GameObject.FindGameObjectWithTag("Player").transform; // �÷��̾��±� ĳ���͸� ã�Ƽ� Ÿ�ٿ� ����       
    }

    void Update() // �����ΰ��� �ٶ󺸴� ���
    {
       turretHead.LookAt(targetTf); // �ͷ���尡 Ÿ���� �ٶ�

        timer += Time.deltaTime;
        if (timer >= cooldownTime)
        {
            timer = 0;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation); // �Ѿ� ����

        }

    }
}
