using UnityEngine; // Unity Engine�� ���ӽ����̽��� ����ϰڴ�.

/// <summary>
/// ����Ƽ �����Ϳ� �ִ� Console�� View�� Log�� �׽�Ʈ�ϱ� ���� Ŭ����
/// </summary>

public class StudyLog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // �ؿ� �ִ� Update�� �����ϱ� ���� ���� ����(ȣ��)�Ѵ�.
    
    void Start()
    {
        Debug.Log("Start �Լ� ����");        
        Debug.LogWarning("Start �Լ� ����");        
        Debug.LogError("Start �Լ� ����");        
    }

    // Update is called once per frame
    // �� �����Ӹ��� �� ���� �����Ѵ�.
    void Update()
    {
 
    }
}
