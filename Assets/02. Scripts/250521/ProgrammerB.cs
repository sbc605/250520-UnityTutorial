using A1;
using UnityEngine;

public class ProgrammerB : MonoBehaviour
{
    public ProgrammerA pA;

    private void Start()
    {
        //pA.number1 = 10;

        pA.number2 = 20;

        //pA.number3 = 30;

        //pA.number4 = 40;

        //pA.number5 = 50;

        Debug.Log("number2의 값은" + pA.number2 + "이다.");
            
    }
}
