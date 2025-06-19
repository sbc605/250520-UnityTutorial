using UnityEngine;

public class MathLight : MonoBehaviour
{
    private Light light;
    private float theta;
    [SerializeField] private float power;
    [SerializeField] private float speed;

    private void Start()
    {
        light = GetComponent<Light>();
    }

    void Update()
    {
        theta += Time.deltaTime * speed;
        // light.intensity = Mathf.Sin(theta) * power; // �ﰢ�Լ� �׷���

        light.intensity = Mathf.PerlinNoise(theta, 0) * power; // ������ ������
    }
}
