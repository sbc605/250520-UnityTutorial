using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    GameObject obj; // 큐브 게임오브젝트를 가져오고 싶다.

    public string changeName;


    void Start()
    {
        obj = GameObject.Find("Main Camera");

        obj.name = changeName;
    }
}
