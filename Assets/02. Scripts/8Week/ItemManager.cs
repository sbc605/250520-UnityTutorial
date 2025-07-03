using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    [SerializeField] private GameObject[] items;

    [SerializeField] private Transform slotGroup;
    public Slot[] slots;

    public GameObject inventoryUI; // �κ��丮 UI
    public Button inventoryButton; // �κ��丮 �Ѵ� ��ư

    void Start()
    {
        // �ڽŰ� �ڽ� �߿��� Slot Component�� �ִ� ����� ��� �������� ���
        slots = slotGroup.GetComponentsInChildren<Slot>(true);

        // �κ��丮 ��ư�� ������ �� OnInventory �Լ� ����
        inventoryButton.onClick.AddListener(OnInventory);
    }

    public void OnInventory()
    {
        
        bool isActive = !inventoryUI.activeSelf;

        inventoryUI.SetActive(isActive);
        // On�̸� Off�� �ǰ� Off�� On�� ��
        
        // Time.timeScale = isActive ? 0f : 1f;
    }

    public void DropItem(Vector3 dropPos)
    {
        // ���� ������ ����
        var randomIndex = Random.Range(0, items.Length);

        // ������ ����
        GameObject item = Instantiate(items[randomIndex], dropPos, Quaternion.identity);
        Rigidbody2D itemRb = item.GetComponent<Rigidbody2D>();

        // ������ �������� ���� ���ϴ� ���
        itemRb.AddForceX(Random.Range(-2f, 2f), ForceMode2D.Impulse);
        itemRb.AddForceY(3f, ForceMode2D.Impulse);

        // ������ ȸ������ ���� ���ϴ� ���
        float ranPower = Random.Range(-1.5f, 1.5f);
        itemRb.AddTorque(ranPower, ForceMode2D.Impulse);
    }

    public void GetItem(IItemObject item)
    {
        foreach (var slot in slots) // ��� ���Կ� ���ؼ�
        {
            if (slot.isEmpty) // ������ ������� ���
            {
                slot.AddItem(item);
                break;                
            }
        }
    }
}
