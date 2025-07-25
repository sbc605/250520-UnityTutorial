using UnityEngine;

public class FlashLight : MonoBehaviour, IDropItem
{
    public GameObject lightObj;

    public void Grab(Transform grabPos)
    {
        transform.SetParent(grabPos);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;

        Debug.Log("손전등을 주웠다.");
    }

    public void Use()
    {
        lightObj.SetActive(!lightObj.activeSelf);
        Debug.Log("손전등을 켠다.");
    }

    public void Drop()
    {
        transform.SetParent(null);
        transform.localPosition = Vector3.zero;

        Debug.Log("손전등을 버렸다.");
    }
}
