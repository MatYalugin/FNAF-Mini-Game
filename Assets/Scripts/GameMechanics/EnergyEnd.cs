using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyEnd : MonoBehaviour
{
    public GameObject officeLight;
    public GameObject lightButton1;
    public GameObject lightButton2;
    public Animator animatorDoor1;
    public Animator animatorDoor2;
    public Animator fanBaldesAnimator;
    public AudioSource officeAudio;
    public GameObject player;
    public GameObject animatronicsManager;
    public GameObject energyEndAudio;


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
        energyEndAudio.SetActive(true);
        officeLight.SetActive(false);
        lightButton1.SetActive(false);
        lightButton2.SetActive(false);
        fanBaldesAnimator.enabled = false;
        officeAudio.Stop();
        animatorDoor1.Play("openDoor");
        animatorDoor2.Play("openDoor");
        player.GetComponent<Tablet>().isWorking = false;
        animatronicsManager.GetComponent<Freddy>().activateFreddy();
        Cursor.lockState = CursorLockMode.Locked;
    }
}
