using UnityEngine;

public class CoinItem : MonoBehaviour, IItem
{
    public enum CoinType {  Gold, Green, Blue }
    public CoinType coinType;

    public float price;

    private Inventory inventory;

    void Start()
    {
        inventory = FindFirstObjectByType<Inventory>();
        Obj = gameObject;
    }

    private void OnMouseDown()
    {
        Get();
    }

    public GameObject Obj { get; set; }

    public void Get()
    {
        Debug.Log($"{this.name}�� ȹ���߽��ϴ�.");

        inventory.AddItem(this);

        gameObject.SetActive(false);
    }
}
