using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCat : MonoBehaviour
{
    public float timer;
    public int waitingTime;
    public GameObject cat1;
    public GameObject cat2;
    
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer > 0)
        {
            //Action
            transform.position += new Vector3(0.13f, 0, 0);
        }
        else
        {
            cat1.SetActive(false);
            cat2.SetActive(true);
        }
    }
}
