using UnityEngine;

public class StudyMaterial : MonoBehaviour
{
    // public Material mat;

    public string hexCode;

    void Start()
    {
        // this.GetComponent<Material>() = mat; // Material�� �ٲٴ� ��� X

        //this.GetComponent<MeshRenderer>().material = mat; // MeshRender�� �����ؼ� �ٲٴ� ���

        //this.GetComponent<MeshRenderer>().sharedMaterial = mat;

        // this.GetComponent<MeshRenderer>().material.color = Color.green;
        // this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green;

        // this.GetComponent<MeshRenderer>().material.color = new Color(120f/255f, 136f/255f, 255f/255f, 1);

        Material mat = this.GetComponent<MeshRenderer>().material;

        Color outputColor; // ��������

        if (ColorUtility.TryParseHtmlString(hexCode, out outputColor))
        {
            mat.color = outputColor;
        }



    }

}
