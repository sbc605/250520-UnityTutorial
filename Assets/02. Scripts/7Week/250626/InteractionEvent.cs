using System.Collections;
using UnityEngine;

public class InteractionEvent : MonoBehaviour
{
    public enum InteractionType { Sign, Door, NPC }
    public InteractionType type;

    public SoundController soundController;

    public GameObject popup, map, house;
    public FadeRoutine fade;

    public Vector3 inDoorPos, outDoorPos;
    public bool inHouse;

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
        soundController.EventSoundPlay("Door Open");

        yield return StartCoroutine(fade.Fade(3f, Color.black, true));

        map.SetActive(inHouse);
        house.SetActive(!inHouse);

        if (inHouse) // 집 > 밖        
            soundController.BgmSoundPlay("Town");      
        
        else if (!inHouse) // 밖 > 집
            soundController.BgmSoundPlay("House");

        var pos = inHouse ? outDoorPos : inDoorPos;
        player.transform.position = pos;

        inHouse = !inHouse;

        soundController.EventSoundPlay("Door Close");

        yield return new WaitForSeconds(1f);
        yield return StartCoroutine(fade.Fade(3f, Color.black, false));

    }
}
