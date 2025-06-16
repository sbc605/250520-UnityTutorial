using UnityEngine;

public class Sword : MonoBehaviour
{
    public float damage = 10f;

    private void OnTriggerEnter(Collider other)
    {
        // ������ ��󿡰� IDamageable�� �ִٸ�
        if(other.GetComponent<IDamageable>() != null)
        {
            // �� ��󿡰� ������ 10�� �ֵ��� �ϰڴ�.
            other.GetComponent<IDamageable>().TakeDamage(10f);
        }
    }
}
