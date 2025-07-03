using UnityEngine;

public class HpPotion : MonoBehaviour, IItemObject
{
    public ItemManager Inventory { get; set; }

    public GameObject Obj { get; set; }
    public string ItemName { get; set; }
    public Sprite Icon { get; set; }

    void Start()
    {
        Inventory = FindFirstObjectByType<ItemManager>();

        Obj = this.gameObject;
        ItemName = this.gameObject.name;
        Icon = this.GetComponent<SpriteRenderer>().sprite;
    }

    public void Get()
    {
        gameObject.SetActive(false); // ������ ���� ��ó�� �����ֱ� ���� ������Ʈ Off
        Inventory.GetItem(this); // �κ��丮���� ������ ȹ���� �˸��� ���
    }

    public void Use()
    {
        Debug.Log("������ ���");
    }

    // �����ΰ� �浹���� �� ����Ǵ� �̺�Ʈ
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) // Tag == Player ���� Ȯ���ϴ� ���ǹ�
            Get();
    }
}
