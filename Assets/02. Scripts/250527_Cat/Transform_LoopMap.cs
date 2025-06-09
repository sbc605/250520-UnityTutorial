using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float returnPosX = 15f;
    public float randomPosY;
    private float PosZ = 9f;

    private void Start() // 처음 시작할 때도 랜덤값
    {
        randomPosY = Random.Range(-7f, -4f);
        transform.position = new Vector3(transform.position.x, randomPosY, PosZ);
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;

        if (transform.position.x <= -returnPosX)
        {
            randomPosY = Random.Range(-7f, -4f);
            transform.position = new Vector3(returnPosX, randomPosY, PosZ);
        }
    }
}
