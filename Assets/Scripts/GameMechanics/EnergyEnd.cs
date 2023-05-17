using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyEnd : MonoBehaviour
{
    public GameObject light;
    public GameObject lightButton1;
    public GameObject lightButton2;
    public Animator animatorDoor1;
    public Animator animatorDoor2;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void energyEndFunction()
    {
        light.SetActive(false);
        lightButton1.SetActive(false);
        lightButton2.SetActive(false);
        animatorDoor1.Play("openDoor");
        animatorDoor2.Play("openDoor");
        player.GetComponent<Tablet>().isWorking = false;
    }
}
