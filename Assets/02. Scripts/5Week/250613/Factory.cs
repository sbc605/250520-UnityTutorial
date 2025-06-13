using UnityEngine;

public class Factory<T> : MonoBehaviour
{
    public T prefab;

    public Factory()
    {
        Debug.Log($"Factory는 {typeof(T)} 타입 입니다.");
        // T에 어떤 타입을 적냐에 따라 컴파일 타임에서 어떤 타입인지 결정
    }
}
