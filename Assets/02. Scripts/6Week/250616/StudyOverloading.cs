using UnityEngine;

public class StudyOverloading : MonoBehaviour
{

    void Start()
    {
        Attack(true);
        Attack(10f);

        // Attack(10, new GameObject("����"));
        GameObject monsterObj = new GameObject("����"); // ���������� ������
        Attack(10, monsterObj);
    }

    
    /* public void Attack()
    {
        Debug.Log("����");
    } */

    public void Attack(bool isMagic)
    {
        if (isMagic)
            Debug.Log("���� ����");
        else
            Debug.Log("�⺻ ����");
    }

    public void Attack(float damage)
    {
        Debug.Log($"{damage} ������ ��ŭ ����");
    }

    public void Attack(float damage, GameObject target)
    {
        Debug.Log($"{target.name}���� {damage} ������ ��ŭ ����");
    }
}
