using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    GameObject obj; // ť�� ���ӿ�����Ʈ�� �������� �ʹ�.

    public string changeName;


    void Start()
    {
        obj = GameObject.Find("Main Camera");

        obj.name = changeName;
    }
}
