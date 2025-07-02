using UnityEngine;

public class HpPotion : MonoBehaviour, IItemObject
{
    public ItemManager Inventory { get; set; }
    public GameObject Obj { get; set; }
    public string ItemName { get; set; }
    public Sprite Icon { get; set; }    

    void Start()
    {
        Obj = gameObject;
        ItemName = name;
        Icon = GetComponent<SpriteRenderer>().sprite;
        Inventory = FindFirstObjectByType<ItemManager>();
    }

    public void Get()
    {
        gameObject.SetActive(false);

        Inventory.GetItem(this);
    }

    public void Use()
    {
        Debug.Log("HP ���� ���");
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Get();
        }
    }
}
