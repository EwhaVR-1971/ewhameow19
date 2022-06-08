using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartGaze : MonoBehaviour
{
    public Image imgGaze;

    public float totalTime;
    bool gvrStatus;
    float gvrTimer;

  // public GameObject cat;
    public Vector3 originScale;

    public GameObject[] prefabs;
    public GameObject instance;
    private BoxCollider area;    //박스콜라이더의 사이즈를 가져오기 위함
    public int count = 10;      //찍어낼 게임 오브젝트 갯수
    
    private List<GameObject> gameObject = new List<GameObject>();
//    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        area = GetComponent<BoxCollider>();
        
        for(int i = 0; i < count; ++i)//count 수 만큼 생성한다
        {
            Spawn();//생성 + 스폰위치를 포함하는 함수
        }
        
        area.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (gvrStatus)
        {
            Debug.Log("look");
            instance.transform.localScale = originScale * (1+gvrTimer);
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;

            if(gvrTimer > totalTime){
             //   cat.SetActive(false);
                Destroy(instance);
            }
        }
    }

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
        //cat.transform.localScale = originScale;
    }

    private Vector3 GetRandomPosition()
    {
        Vector3 basePosition = transform.position;
        Vector3 size = area.size;
        
        float posX = basePosition.x + Random.Range(-size.x/2f, size.x/2f);
        float posY = basePosition.y + Random.Range(-size.y/2f, size.y/2f);
        float posZ = basePosition.z + Random.Range(-size.z/2f, size.z/2f);
        
        Vector3 spawnPos = new Vector3(posX, posY, posZ);
        
        return spawnPos;
    }

    private void Spawn()
    {
        Debug.Log("spaw ok");
        int selection = Random.Range(0, prefabs.Length);
        
        GameObject selectedPrefab = prefabs[selection];
        
        Vector3 spawnPos = GetRandomPosition();//랜덤위치함수
        
        instance = Instantiate(selectedPrefab, spawnPos, Quaternion.identity);
        gameObject.Add(instance);
        
        originScale = instance.transform.localScale;
    }
}