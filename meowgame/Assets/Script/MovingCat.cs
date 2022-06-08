using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCat : MonoBehaviour
{
    public float timer;
    public int waitingTime;
    
    void Update()
    {
        timer += Time.deltaTime;

        if (timer < waitingTime)
        {
            //Action
            transform.position += new Vector3(0.1f, 0, 0);
        }
    }
}
