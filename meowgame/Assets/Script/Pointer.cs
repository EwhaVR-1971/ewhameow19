using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pointer : MonoBehaviour
{
    float time;
    bool flag;

    
    /*

    private float size = 2f;
    public float speed;
    public float time;

    private Vector2 originScale; //원래 크기

    private void Awake()
    {
        originScale = transform.localScale; //원래 크기 저장
    }   


    public void Size(){
        transform.localScale = originScale*(1+time);
        time += Time.deltaTime;
    }
    
    */

    
    public void Update()
    {
        Debug.Log("look");
        if(flag){
            transform.localScale = Vector3.one * (1+time);
            time += Time.deltaTime;
            if (time > 1f)
            {
                gameObject.SetActive(false);
            }
        }
        
    }

    public void GVROn(){
        flag = true;
    }

    public void GVROff(){
        flag = false;
        time = 0;
        transform.localScale = Vector3.one;
    }
}
