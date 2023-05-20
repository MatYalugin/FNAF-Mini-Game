using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Freddy : MonoBehaviour
{
    public float timeToKill;
    public GameObject jumpscare;
    public int loseMenuIndex = 3;
    public GameObject player;
    public GameObject tablet;
    public MonoBehaviour bonnieScript;
    public MonoBehaviour chicaScript;
    public MonoBehaviour foxyScript;

    public GameObject button1;
    public GameObject button2;
    public GameObject recourcesManager;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void activateFreddy()
    {
        Invoke("killPlayer", timeToKill);
        bonnieScript.enabled = false;
        chicaScript.enabled = false;
        foxyScript.enabled = false;
    }
    public void killPlayer()
    {
        jumpscare.SetActive(true);
        player.GetComponent<Tablet>().isWorking = false;
        Invoke("goToLoseMenu", 2.5f);
        tablet.SetActive(false);
        player.GetComponent<PlayerRotation>().enabled = false;

        button1.GetComponent<Buttons>().isReadyToInteract = false;
        button2.GetComponent<Buttons>().isReadyToInteract = false;
        recourcesManager.SetActive(false);
    }
    public void goToLoseMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(loseMenuIndex);
    }
}
