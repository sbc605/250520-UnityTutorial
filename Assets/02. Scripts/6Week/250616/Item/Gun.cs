using UnityEngine;

public class Gun : MonoBehaviour, IDropItem
{
    public void Use()
    {
        Debug.Log("���� �߻��Ѵ�.");  
    }

    public void Grab()
    {
        Destroy(gameObject);
        Debug.Log("���� �ֿ���.");
    }

    public void Drop()
    {
        Debug.Log("���� ���ȴ�.");
    }
}
