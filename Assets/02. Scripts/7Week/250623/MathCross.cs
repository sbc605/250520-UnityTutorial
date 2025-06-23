using UnityEngine;

public class MathCross : MonoBehaviour
{
    public Vector3 vecA = new Vector3(1, 0, 0);
    public Vector3 vecB = new Vector3(0, 1, 0);

    void Start()
    {
        // Vector3 result = Vector3.Cross(vecA, vecB);
        var result = Vector3.Cross(vecA, vecB).z;

        Debug.Log($"������ ���� : {result}");
    }
}
