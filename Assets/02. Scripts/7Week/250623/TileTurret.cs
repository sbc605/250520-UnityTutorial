using UnityEngine;

public class TileTurret : MonoBehaviour
{
    public GameObject[] turretPrefab;

    private void OnMouseDown()
    {
        Instantiate(turretPrefab[SetTile.turretIndex], transform.position, Quaternion.identity);
    }
}
