using UnityEngine;

public class WirelessEarPhone : EarPhone
{
    public float batterySize;
    public bool isWirelessCharged;

    private void Start()
    {
        name = "AirPod1";
        price = 100f;
        releaseYear = 2007;
        batterySize = 70f;
    }

    public void Charged()
    {
        string msg = isWirelessCharged ? "���� ����" : "���� ����";
        Debug.Log(msg);
        
        /* if�� ���
         * if (isWirelessCharged)
            Debug.Log("���� ����");
        else
            Debug.Log("���� ����");
        */


    }

}
