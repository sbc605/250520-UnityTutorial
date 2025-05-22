using System;
using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;
    
    void Start()
    {
       CreateCharacter();

       // Destroy(destroyObj, 3f); // 3�� �ڿ� �ı���Ű�� ���
    }

    /// <summary>
    /// ĳ���͸� �����ϰ� �̸��� �����ϴ� ���
    /// </summary>
    public void CreateCharacter()
    {
        GameObject obj = Instantiate(prefab); // GameObject�� �����ϴ� ���
        // Instantiate(prefab, pos, rot).name = "���� ĳ����";
        obj.name = "���Ⱦư���";
        Transform objTF = obj.transform;
        int count = objTF.childCount;

        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� �� : {count}");
        Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸� : {objTF.GetChild(0).name}");
        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸� : {objTF.GetChild(count - 1).name}");


    }

    //public GameObject destroyObj;

    //public Vector3 pos;
    //public Quaternion rot;

    //void OnDestroy()
    //{
    //    Debug.Log("�ı��Ǿ����ϴ�.");
    //}

}
