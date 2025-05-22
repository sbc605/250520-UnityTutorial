using System;
using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;
    
    void Start()
    {
       CreateCharacter();

       // Destroy(destroyObj, 3f); // 3초 뒤에 파괴시키는 기능
    }

    /// <summary>
    /// 캐릭터를 생성하고 이름을 변경하는 기능
    /// </summary>
    public void CreateCharacter()
    {
        GameObject obj = Instantiate(prefab); // GameObject를 생성하는 기능
        // Instantiate(prefab, pos, rot).name = "어몽어스 캐릭터";
        obj.name = "나안아강쥐";
        Transform objTF = obj.transform;
        int count = objTF.childCount;

        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {count}");
        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {objTF.GetChild(0).name}");
        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {objTF.GetChild(count - 1).name}");


    }

    //public GameObject destroyObj;

    //public Vector3 pos;
    //public Quaternion rot;

    //void OnDestroy()
    //{
    //    Debug.Log("파괴되었습니다.");
    //}

}
