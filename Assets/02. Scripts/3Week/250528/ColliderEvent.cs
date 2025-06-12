using UnityEngine;

namespace GameOver
{
    public class ColliderEvent : MonoBehaviour
    {
        /*void OnCollisionEnter(Collision other)
        //{
        //    Debug.Log("Collision Enter");
        //}

        //void OnTriggerEnter(Collider other)
        //{
        //    Debug.Log("Trigger Enter");
        }*/

        public GameObject fadeUI;

        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Game Over");
                fadeUI.SetActive(true);
            }
        }

    }

}
