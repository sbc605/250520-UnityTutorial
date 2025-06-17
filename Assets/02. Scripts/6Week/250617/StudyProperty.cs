using UnityEngine;

public class StudyProperty : MonoBehaviour
{
    /* 
    private int number1 = 10;
    public int Number1
    {
        get { return number1; }
        private set { number1 = value; }
    }

    public int Number2 { get; } = 20;
    public int Number3 { get; private set; } = 30;

    private float hp = 100f;
    public float Hp
    {
        get { return hp; }
        set
        {

        }
    }

    private SoundManager sound;
    public SoundManager Sound
    {
        get
        {
            if (sound == null)
                sound = FindFirstObjectByType<SoundManager>();

            return sound;
        }
    } */

    [Header("�ӵ�")]
    [SerializeField] private float moveSpeed = 10f;

    [Space(10)] // ��ĭ ����
    [Header("�ӵ�2")] // �ѱ� �ۼ� ����
    [Range(0f, 10f)] // �ӵ��� 0~10�̴� (�����̴���)
    [field: SerializeField] 
    private float moveSpeed2 = 10f;
    public float MoveSpeed2
    {
        get { return moveSpeed2; }
        set { moveSpeed2 = value; }
    }

    [HideInInspector]
    public int level = 10;
}