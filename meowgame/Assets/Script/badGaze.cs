using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class badGaze : MonoBehaviour
{
    public Image imgGaze_bad;

    public float totalTime_bad;
    bool gvrStatus_bad;
    float gvrTimer_bad;
    public GameObject bad_ciao;
    public Vector3 originScale_bad;
    // Start is called before the first frame update
    void Start()
    {
        originScale_bad = bad_ciao.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus_bad)
        {
            bad_ciao.transform.localScale = originScale_bad * (1 + gvrTimer_bad);
            gvrTimer_bad += Time.deltaTime;
            imgGaze_bad.fillAmount = gvrTimer_bad / totalTime_bad;

            if (gvrTimer_bad > totalTime_bad)
            {
                bad_ciao.SetActive(false);
            }
        }
    }

    public void GVROn()
    {
        gvrStatus_bad = true;
    }

    public void GVROff()
    {
        gvrStatus_bad = false;
        gvrTimer_bad = 0;
        imgGaze_bad.fillAmount = 0;
        bad_ciao.transform.localScale = originScale_bad;
    }
}