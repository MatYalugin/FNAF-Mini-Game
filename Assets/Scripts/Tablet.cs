using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablet : MonoBehaviour
{
    public GameObject resourcesManager;
    public GameObject tablet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && tablet.activeSelf == false)
        {
            tablet.SetActive(true);
            resourcesManager.GetComponent<Energy>().tabletOn = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && tablet.activeSelf == true)
        {
            resourcesManager.GetComponent<Energy>().tabletOn = false;
            tablet.SetActive(false);
        }
    }
}
