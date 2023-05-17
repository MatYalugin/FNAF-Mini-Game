using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablet : MonoBehaviour
{
    public GameObject resourcesManager;
    public GameObject tablet;
    public bool isWorking = true;
    private bool isReady = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && tablet.activeSelf == false && isWorking != false && isReady != false)
        {
            tablet.SetActive(true);
            resourcesManager.GetComponent<Energy>().tabletOn = true;
            isReady = false;
            Invoke("makeReadyToUse", 1.2f);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && tablet.activeSelf == true)
        {
            resourcesManager.GetComponent<Energy>().tabletOn = false;
            tablet.SetActive(false);
        }
    }
    public void makeReadyToUse()
    {
        isReady = true;
    }
}
