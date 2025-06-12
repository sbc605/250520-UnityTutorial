using UnityEngine;

public class ItemEvent : MonoBehaviour
{
    public enum ColliderType { Pipe, Apple, Both }
    public ColliderType colliderType;

    public GameObject particle;
    public GameObject pipe;
    public GameObject apple;

    public float moveSpeed = 0.1f;
    public float returnPosX = 15f;
    public float randomPosY;
    private float PosZ = 9f;

    private Vector3 initPos;

    private void Awake()
    {
        initPos = transform.localPosition;
    }

    private void OnEnable()
    {
        SetRandomSetting(initPos.x);
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;

        if (transform.position.x <= -returnPosX)
        {
            SetRandomSetting(returnPosX);
        }       
    }

    void SetRandomSetting(float posX)
    {
        randomPosY = Random.Range(-7f, -4f);
        transform.position = new Vector3(posX, randomPosY, PosZ);

        pipe.SetActive(false);
        apple.SetActive(false);
        particle.SetActive(false);

        colliderType = (ColliderType)Random.Range(0, 3);

        switch (colliderType)
        {
            case ColliderType.Pipe:
                pipe.SetActive(true);
                break;

            case ColliderType.Apple:
                apple.SetActive(true);
                break;

            case ColliderType.Both:
                pipe.SetActive(true);
                apple.SetActive(true);
                break;

        }
    }
}
