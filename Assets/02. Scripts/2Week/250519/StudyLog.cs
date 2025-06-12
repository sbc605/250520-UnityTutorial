using UnityEngine; // Unity Engine의 네임스페이스를 사용하겠다.

/// <summary>
/// 유니티 에디터에 있는 Console의 View에 Log를 테스트하기 위한 클래스
/// </summary>

public class StudyLog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // 밑에 있는 Update를 실행하기 전에 먼저 실행(호출)한다.
    
    void Start()
    {
        Debug.Log("Start 함수 실행");        
        Debug.LogWarning("Start 함수 실행");        
        Debug.LogError("Start 함수 실행");        
    }

    // Update is called once per frame
    // 매 프레임마다 한 번씩 실행한다.
    void Update()
    {
 
    }
}
