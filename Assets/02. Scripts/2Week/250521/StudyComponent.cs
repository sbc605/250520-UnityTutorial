using UnityEngine; // UnityEngine�̶�� ���ӽ����̽��� Ȱ���ϰڴ�.

 //����������     Ŭ������     : ����Ƽ�� ������ ����� ����ִ� ��
public class StudyComponent : MonoBehaviour
{
  // ����������  Ÿ��    ������;
      public GameObject obj; // ť�� ���ӿ�����Ʈ�� �������� �ʹ�.

    public Transform objTF;

      // public string changeName;
      //����������  Ÿ��    �����̸�

   //Ÿ�� �Լ��� 
    void Start()
    {
        // obj = GameObject.Find("Main Camera"); // Main Camera ������Ʈ�� ã�Ƽ� �Ҵ��ϴ� ���

        // Player��� Tag�� ���� ���ӿ�����Ʈ�� ã�Ƽ� obj�� �Ҵ�
        obj = GameObject.FindGameObjectWithTag("Player");

        objTF = GameObject.FindGameObjectWithTag("Player").transform;
        // objTF = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        objTF.gameObject.SetActive(false);

        // obj�� MeshRenderer�� �����ؼ� Ȱ�����¸� false�� �����ϰڴ�.
        //obj.GetComponent<MeshRenderer>().enabled = false;

        //// obj�� GameObject Ȱ�����¸� false (���� ���)
        //obj.SetActive(false);

        //Debug.Log($"<color=#FF0000>�̸� : {obj.name}</color>"); // ���ӿ�����Ʈ�� �̸�
        //Debug.Log($"<color=#00FF00>�±� : {obj.tag}</color>"); // ���ӿ�����Ʈ�� �±�
        //Debug.Log($"<color=#0000FF>��ġ : {obj.transform.position}</color>"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ��ġ
        //Debug.Log($"��ġ : {GetComponent<Transform>().rotation}");
        //Debug.Log($"<color=#FFFF00>ȸ�� : {obj.transform.rotation} </color>"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ȸ��
        //Debug.Log($"<color=#FF00FF>ũ�� : {obj.transform.localScale}</color>"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ũ��

        //Debug.Log($"Mesh ������ : {obj.GetComponent<MeshFilter>().mesh}"); // MeshFilter ������Ʈ ����, mesh Log ���
        //Debug.Log($"Material ������ : {obj.GetComponent<MeshRenderer>().material}"); // MeshRenderer ������Ʈ ����, material Log ���

        //obj.name = changeName;
        
    }
}
