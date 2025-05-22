using UnityEngine;

public class MakingCube : MonoBehaviour
{
    public GameObject obj;

    public Mesh msh;
    public Material mat;

    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        
        CreateCube(); 
        CreateCube("Hello World"); 
    }

    public void CreateCube(string name = "Cube")
    {
        // obj = new GameObject();
        // obj.name = "Cube";
        obj = new GameObject(name); // 빈 게임 오브젝트 생성. 이름은 큐브.

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();               
    }    

}
