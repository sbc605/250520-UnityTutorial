using UnityEngine;

public class FlashLight : MonoBehaviour, IDropItem
{
    public GameObject lightObj;

    public void Grab(Transform grabPos)
    {
        transform.SetParent(grabPos);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;

        Debug.Log("�������� �ֿ���.");
    }

    public void Use()
    {
        lightObj.SetActive(!lightObj.activeSelf);
        Debug.Log("�������� �Ҵ�.");
    }

    public void Drop()
    {
        transform.SetParent(null);
        transform.localPosition = Vector3.zero;

        Debug.Log("�������� ���ȴ�.");
    }
}
