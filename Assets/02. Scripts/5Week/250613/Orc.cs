using UnityEngine;

public class Orc : Monster
{
    void Start()
    {
        Monster monster = new Orc();
        Orc orc = monster as Orc; // ������ ����ȯ, ���н� null

        if (orc != null)
            Debug.Log(orc);

        else // if (o == null)
            Debug.Log("����ȯ ���� ����"); // �α׷� ��
    }

}
