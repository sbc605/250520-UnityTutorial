using System.Collections;
using UnityEngine;

public class InteractionEvent : MonoBehaviour
{
    public enum InteractionType { Sign, Door, NPC }
    public InteractionType type;

    public GameObject popup, map, house;
    public FadeRoutine fade;

    public Vector3 inDoorPos, outDoorPos;
    public bool isHouse;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Interaction(other.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            popup.SetActive(false);
        }
    }

    void Interaction(Transform player)
    {
        switch (type)
        {
            case InteractionType.Sign:
                popup.SetActive(true);
                break;

            case InteractionType.Door:
                StartCoroutine(DoorRoutine(player));
                break;

            case InteractionType.NPC:
                popup.SetActive(true);
                break;
        }
    }

    IEnumerator DoorRoutine(Transform player)
    {
        yield return StartCoroutine(fade.Fade(3f, Color.black, true));

        map.SetActive(isHouse);
        house.SetActive(!isHouse);

        var pos = isHouse ? outDoorPos : inDoorPos;
        player.transform.position = pos;

        /*
        if (!isHouse)
        {
            map.SetActive(false);
            house.SetActive(true);
            player.transform.position = inDoorPos;
        }
        else
        {
            map.SetActive(true);
            house.SetActive(false);
            player.transform.position = outDoorPos;
        } */

        isHouse = !isHouse;
        yield return new WaitForSeconds(1f);

        yield return StartCoroutine(fade.Fade(3f, Color.black, false));
    }
}
