using UnityEngine;

public interface IDropItem
{    
    void Grab(Transform grabPos); // ������ �ݱ�

    void Use(); // ������ ����ϱ�

    void Drop(); // ������ ������
        
}
