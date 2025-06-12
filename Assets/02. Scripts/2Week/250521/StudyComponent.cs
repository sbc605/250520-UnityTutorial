using UnityEngine; // UnityEngine이라는 네임스페이스를 활용하겠다.

 //접근제한자     클래스명     : 유니티의 유용한 기능이 들어있는 곳
public class StudyComponent : MonoBehaviour
{
  // 접근제한자  타입    변수명;
      public GameObject obj; // 큐브 게임오브젝트를 가져오고 싶다.

    public Transform objTF;

      // public string changeName;
      //접근제한자  타입    변수이름

   //타입 함수명 
    void Start()
    {
        // obj = GameObject.Find("Main Camera"); // Main Camera 오브젝트를 찾아서 할당하는 기능

        // Player라는 Tag를 가진 게임오브젝트를 찾아서 obj에 할당
        obj = GameObject.FindGameObjectWithTag("Player");

        objTF = GameObject.FindGameObjectWithTag("Player").transform;
        // objTF = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        objTF.gameObject.SetActive(false);

        // obj의 MeshRenderer에 접근해서 활성상태를 false로 변경하겠다.
        //obj.GetComponent<MeshRenderer>().enabled = false;

        //// obj의 GameObject 활성상태를 false (끄는 기능)
        //obj.SetActive(false);

        //Debug.Log($"<color=#FF0000>이름 : {obj.name}</color>"); // 게임오브젝트의 이름
        //Debug.Log($"<color=#00FF00>태그 : {obj.tag}</color>"); // 게임오브젝트의 태그
        //Debug.Log($"<color=#0000FF>위치 : {obj.transform.position}</color>"); // 게임오브젝트의 Transform 컴포넌트의 위치
        //Debug.Log($"위치 : {GetComponent<Transform>().rotation}");
        //Debug.Log($"<color=#FFFF00>회전 : {obj.transform.rotation} </color>"); // 게임오브젝트의 Transform 컴포넌트의 회전
        //Debug.Log($"<color=#FF00FF>크기 : {obj.transform.localScale}</color>"); // 게임오브젝트의 Transform 컴포넌트의 크기

        //Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}"); // MeshFilter 컴포넌트 접근, mesh Log 출력
        //Debug.Log($"Material 데이터 : {obj.GetComponent<MeshRenderer>().material}"); // MeshRenderer 컴포넌트 접근, material Log 출력

        //obj.name = changeName;
        
    }
}
