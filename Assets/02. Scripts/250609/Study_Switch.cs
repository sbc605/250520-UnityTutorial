using UnityEngine;

public class Study_Switch : MonoBehaviour
{
    public enum CalculationType { Plus, Minus, Multiply, Divide } // 열거형 생성
    public CalculationType calculationType = CalculationType.Plus; // 접근하기 위해 CalculationType타입을 받는 변수를 하나 만들어 할당함

    public int input1, input2, result; // 이렇게 붙여서 적을 수 있음
    // 입력할 값(input)과 나올 결과(result)

    void Start()
    {
        Debug.Log($"계산 결과 : {Calculation()}"); // return타입이라 result = Calculation(); 안 적어도 됨
    }

    int Calculation() // 계산하는 함수
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

        return result; // 특정 타입의 값을 반환하는 방식
        // result 값이 여기로 옴
    }


}
