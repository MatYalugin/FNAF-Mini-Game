using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour
{
    private float energyCounter;
    public int energy = 100;
    public Text energyText;
    private bool speedTimeTick = true;
    //energy minus speed
    public float speedTime = 10;
    //speed change conditions
    public bool tabletOn;
    public bool leftDoorOn;
    public bool rightDoorOn;
    //calculate if the speed has already changed
    bool tabletOnPrevious = false;
    bool rightDoorOnPrevious = false;
    bool leftDoorOnPrevious = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //changing speed
        if (tabletOn != tabletOnPrevious)
        {
            if (tabletOn == true)
            {
                speedTime -= 1.5f;
            }
            else
            {
                speedTime += 1.5f;
            }
            tabletOnPrevious = tabletOn;
        }

        if (rightDoorOn != rightDoorOnPrevious)
        {
            if (rightDoorOn == true)
            {
                speedTime -= 2;
            }
            else
            {
                speedTime += 2;
            }
            rightDoorOnPrevious = rightDoorOn;
        }

        if (leftDoorOn != leftDoorOnPrevious)
        {
            if (leftDoorOn == true)
            {
                speedTime -= 2;
            }
            else
            {
                speedTime += 2;
            }
            leftDoorOnPrevious = leftDoorOn;
        }



        energyText.text = "Energy: " + energy + "%";
        if(speedTimeTick == true)
        {
            energyCounter += Time.deltaTime;
            if (energyCounter >= speedTime)
            {
                minusEnergy();
                energyCounter = 0f;
            }
        }
        if (energy <= 0)
        {
            speedTimeTick = false;
            energy = 0;
            gameObject.GetComponent<EnergyEnd>().energyEndFunction();
        }
    }
    public void minusEnergy()
    {
        energy -= 1;
    }

}
