using UnityEngine;

public class WirelessEarPhone2 : WirelessEarPhone
{
    public bool isNoiseCancelling;

    private void Start()
    {
        name = "AirPod2";
        price = 150f;
        releaseYear = 2010;
        batterySize = 100f;
    }

    public virtual void NoiseCancelling()
    {
        isNoiseCancelling = !isNoiseCancelling;

        string msg = isNoiseCancelling ? "������ ĵ���� On" : "������ ĵ���� Off";
        Debug.Log(msg);
    }
    
}
