using UnityEngine;

public class Character : MonoBehaviour
{
    /* public float hp;
    public float moveSpeed;

    public void Move()
    {
        Debug.Log("�̵�");
    }


    public virtual void Attack()
    {
        Debug.Log("����");
    }

    public abstract void Hit();
    */

    /* private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Flash Light"))
        {
            other.GetComponent<FlashLight>().FlashOn();
        }
        else if (other.CompareTag("Gun"))
        {
            other.GetComponent<Gun>().Shoot();
        }
    } */

    public IDropItem currentItem;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentItem.Use();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            currentItem.Drop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<IDropItem>() != null) // ������ ��� IDropItem�� �ִٸ�
        {
            IDropItem item = other.GetComponent<IDropItem>(); // �������� ����

            item.Grab(); // ������ ȹ��

            currentItem = item; // ���� ������ ����
        }
    }
}

