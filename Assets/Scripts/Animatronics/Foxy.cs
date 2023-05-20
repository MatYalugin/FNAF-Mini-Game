using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Foxy : MonoBehaviour
{
    public bool check = true;
    private float checkCounter;
    public float checkTime;
    public float killCounter;
    public float killTime;
    private bool killCounterTick;
    public GameObject tabletManager;
    public GameObject leftButton;
    public GameObject player;
    public GameObject jumpscare;
    public int loseMenuIndex = 3;
    public GameObject tablet;
    public bool attackingPlayer = false;

    public AudioSource runAudio;
    public AudioSource doorKickAudio;

    private bool endAttackTimeReseted = false;
    private bool killCounterTickExecuted = false;

    public MonoBehaviour freddyScript;
    public MonoBehaviour chicaScript;
    public MonoBehaviour bonnieScript;

    public GameObject button1;
    public GameObject button2;

    public GameObject recourcesManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (attackingPlayer == true)
        {
            if (leftButton.GetComponent<Buttons>().doorClosed)
            {
                if (endAttackTimeReseted == false)
                {
                    endAttack();
                    killCounter = 0;
                    killCounterTick = false;
                    endAttackTimeReseted = true;
                }
                killCounterTickExecuted = false;
            }
            else
            {
                if (killCounterTickExecuted == false)
                {
                    endAttackTimeReseted = false;
                    killCounterTick = true;
                    killCounterTickExecuted = true;
                }
            }
        }

        if (check == true)
        {
            checkCounter += Time.deltaTime;
            if (checkCounter >= checkTime)
            {
                checkAttack();
                checkCounter = 0f;
            }
        }

        if (killCounterTick == true)
        {
            killCounter += Time.deltaTime;
            if (killCounter >= killTime)
            {
                killPlayer();
                killCounterTick = false;
                killCounter = 0f;
            }
        }

    }
    public void checkAttack()
    {
        if (Random.value < 0.20f)
        {
            attack();
        }
    }
    public void attack()
    {
        runAudio.Play();
        check = false;
        tabletManager.GetComponent<TabletManager>().MushOnLeftCam = true;
        tabletManager.GetComponent<TabletManager>().setLeftCameraMush();
        attackingPlayer = true;
        killCounter = 0;
    }
    public void endAttack()
    {
        recourcesManager.GetComponent<Energy>().energy -= 5;
        doorKickAudio.Play();
        runAudio.Stop();
        tabletManager.GetComponent<TabletManager>().MushOnLeftCam = false;
        tabletManager.GetComponent<TabletManager>().removeLeftCameraMush();
        check = true;
        killCounterTick = false;
        attackingPlayer = false;
    }
    public void killPlayer()
    {
        jumpscare.SetActive(true);
        player.GetComponent<Tablet>().isWorking = false;
        Invoke("goToLoseMenu", 2.5f);
        tablet.SetActive(false);
        player.GetComponent<PlayerRotation>().enabled = false;
        freddyScript.enabled = false;
        chicaScript.enabled = false;
        bonnieScript.enabled = false;

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
