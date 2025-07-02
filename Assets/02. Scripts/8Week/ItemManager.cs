using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] private GameObject[] items;

    public void DropItem(Vector3 dropPos)
    {
        var randomIndex = Random.Range(0, items.Length); // ���� ������ ����

        /// �Ӹ� ���� ���ư���
        GameObject item = Instantiate(items[randomIndex], dropPos, Quaternion.identity); // ���õ� ������ ����

        Rigidbody2D itemRb = item.GetComponent<Rigidbody2D>(); // ���� �Ŀ�/�������� �Ѹ���

        itemRb.AddForceX(Random.Range(-2f, 2f), ForceMode2D.Impulse);
        itemRb.AddForceY(3f, ForceMode2D.Impulse);
        // ���� ���: itemRb.AddForce(new Vector2(Random.Range(-2f,2f), 3f), ForceMode2D.Impulse);

        // ������ ȸ�� ��� �߰�
        float ranPower = Random.Range(-1f, 1f);
        itemRb.AddTorque(ranPower, ForceMode2D.Impulse);
    }

    public void GetItem(IItemObject item)
    {

    }
}
