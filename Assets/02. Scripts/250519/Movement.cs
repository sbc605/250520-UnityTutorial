using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // this.transform.position = this.transform.position + Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position + Vector3.forward * moveSpeed;
    }
}
