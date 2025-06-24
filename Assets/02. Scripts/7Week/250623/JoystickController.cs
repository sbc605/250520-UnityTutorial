using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] private KnightController_Joystick knightController;
    [SerializeField] private GameObject backgroundUI;
    [SerializeField] private GameObject handlerUI;

    private Vector2 startPos, currPos;

    void Start()
    {
        backgroundUI.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        backgroundUI.SetActive(true);
        backgroundUI.transform.position = eventData.position;
        startPos = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        currPos = eventData.position;
        Vector2 dragDir = currPos - startPos; // 현재 드래그하는 방향

        float maxDist = Mathf.Min(dragDir.magnitude, 75f); // a와 b중 최소값을 뽑는다.

        handlerUI.transform.position = startPos + dragDir.normalized * maxDist;

        knightController.InputJoystick(dragDir.x, dragDir.y);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        knightController.InputJoystick(0, 0);
        handlerUI.transform.localPosition = Vector2.zero;
        backgroundUI.SetActive(false);
    }
}
