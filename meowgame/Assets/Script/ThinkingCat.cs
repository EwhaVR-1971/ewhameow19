using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThinkingCat : MonoBehaviour
{
    public float timer;
    public GameObject thought3;


    void Update()
    {
        // waitingTime -= Time.deltaTime;
        timer += Time.deltaTime;

        if (timer > 3)
        {
            //Action
            thought3.SetActive(true);
        }
    }
}
