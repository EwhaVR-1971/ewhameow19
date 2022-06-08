using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Trigger : MonoBehaviour
{
    public HeartGaze prefab;

    void Start(){
        prefab = GameObject.Find("Player").GetComponent<HeartGaze>();

        EventTrigger.Entry entey = new EventTrigger.Entry();
        entey.eventID = EventTriggerType.PointerEnter;
        entey.callback.AddListener( (eventData) => { prefab.GVROn(); });

        GetComponent<EventTrigger>().triggers.Add(entey);
    }
}