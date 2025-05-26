using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 100f;
    public float destroyTime = 1f;

    void Update()
    {
        transform.position += transform.up * bulletSpeed * Time.deltaTime;
        Destroy(this.gameObject, destroyTime);
    }
}
