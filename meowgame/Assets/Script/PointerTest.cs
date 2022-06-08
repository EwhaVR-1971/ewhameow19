using UnityEngine;
using UnityEngine.EventSystems;


public class PointerTester : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler 
{

// Use this for initialization
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pointer is Down");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Pointer is Up");
    }
}