using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chica : MonoBehaviour
{
    public bool check = true;
    private float checkCounter;
    public float checkTime;
    public float killCounter;
    public float killTime;
    private bool killCounterTick;
    public GameObject tabletManager;
    public GameObject rightButton;
    public GameObject player;
    public GameObject jumpscare;
    public int loseMenuIndex = 3;
    public GameObject tablet;
    public bool attackingPlayer = false;

    private bool endAttackTimeReseted = false;
    private bool killCounterTickExecuted = false;

    public MonoBehaviour bonnieScript;
    public MonoBehaviour freddyScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (attackingPlayer == true)
        {
            if (rightButton.GetComponent<Buttons>().doorClosed)
            {
                if (endAttackTimeReseted == false)
                {
                    killCounter = 0;
                    killCounterTick = false;
                    Invoke("endAttack", 20);
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

        if(killCounterTick == true)
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
        if (Random.value < 0.1f)
        {
            attack();
        }
    }
    public void attack()
    {
        check = false;
        tabletManager.GetComponent<TabletManager>().ChicaOnCam = true;
        tabletManager.GetComponent<TabletManager>().setChicaOnRightHall();
        attackingPlayer = true;
        killCounter = 0;
    }
    public void endAttack()
    {
        tabletManager.GetComponent<TabletManager>().ChicaOnCam = false;
        tabletManager.GetComponent<TabletManager>().removeChicaOnRightHall();
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
        bonnieScript.enabled = false;
        freddyScript.enabled = false;
    }
    public void goToLoseMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(loseMenuIndex);
    }
}