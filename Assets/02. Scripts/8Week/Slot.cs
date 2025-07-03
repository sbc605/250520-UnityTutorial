using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    private IItemObject item; // ���Կ� ���� ������
    [SerializeField] private Image itemImage; // ���� �������� �̹����� �� ��ġ
    [SerializeField] private Button slotButton; // ������ Use()�� �ϱ� ���� ��ư

    public bool isEmpty = true;

    void Awake()
    {
        slotButton.onClick.AddListener(UseItem);
    }

    void OnEnable() // ������Ʈ�� On�� ������ 1�� ����Ǵ� ���
    {
        /*
        if (isEmpty) // ������ ������� ��
        {
            slotButton.interactable = false;
            itemImage.gameObject.SetActive(false);
        }
        else // ������ ������ ��
        {
            slotButton.interactable = true;
            itemImage.gameObject.SetActive(true);
        } */


        slotButton.interactable = !isEmpty;
        itemImage.gameObject.SetActive(!isEmpty);
    }

    public void AddItem(IItemObject newItem)
    {
        item = newItem;
        isEmpty = false;
        itemImage.sprite = newItem.Icon;
        itemImage.SetNativeSize();

        // �ǽð����� �Դ°� Ȯ��
        slotButton.interactable = !isEmpty;
        itemImage.gameObject.SetActive(!isEmpty);
    }

    public void UseItem()
    {
        if (item != null)
        {
            item.Use();
            ClearSlot();
        }
    }

    public void ClearSlot()
    {
        item = null;
        isEmpty = true;
        slotButton.interactable = !isEmpty;
        itemImage.gameObject.SetActive(!isEmpty);
    }
}

