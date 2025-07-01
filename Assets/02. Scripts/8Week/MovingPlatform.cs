using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public enum MoveType { Horizontal, Vertical }
    public MoveType movetype;

    public float theta;
    public float power = 0.1f;
    public float speed = 1f;

    private Vector3 initPos;


    void Start()
    {
        initPos = transform.position;
    }

    void Update()
    {
        theta += Time.deltaTime * speed;

        if (movetype == MoveType.Horizontal)
        transform.position = new Vector3(initPos.x + power * Mathf.Sin(theta), initPos.y, initPos.z);
        else if (movetype == MoveType.Vertical)
            transform.position = new Vector3(initPos.x, initPos.y + power * Mathf.Sin(theta), initPos.z);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(transform); // �ش� ���(ĳ����)�� �θ� �ڽ�(�÷���)���� ������          
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(null);
        }
    }
}
