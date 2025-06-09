using UnityEngine;

public class Study_Switch : MonoBehaviour
{
    public enum CalculationType { Plus, Minus, Multiply, Divide } // ������ ����
    public CalculationType calculationType = CalculationType.Plus; // �����ϱ� ���� CalculationTypeŸ���� �޴� ������ �ϳ� ����� �Ҵ���

    public int input1, input2, result; // �̷��� �ٿ��� ���� �� ����
    // �Է��� ��(input)�� ���� ���(result)

    void Start()
    {
        Debug.Log($"��� ��� : {Calculation()}"); // returnŸ���̶� result = Calculation(); �� ��� ��
    }

    int Calculation() // ����ϴ� �Լ�
    {
        int value;

        switch (calculationType)
        {
            case CalculationType.Plus:
                result = input1 + input2;
                break;
            case CalculationType.Minus:
                result = input1 - input2;
                break;
            case CalculationType.Multiply:
                result = input1 * input2;
                break;
            case CalculationType.Divide:
                result = input1 / input2;
                break;
        }

        return result; // Ư�� Ÿ���� ���� ��ȯ�ϴ� ���
        // result ���� ����� ��
    }


}
