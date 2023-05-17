using UnityEngine;

public class Buttons : MonoBehaviour
{
    private bool isMouseOver;
    public Animator doorAnimator;
    public bool doorClosed;
    public GameObject resourcesManager;
    public int doorNumber;

    private void OnMouseDown()
    {
        if (isMouseOver)
        {
            if (doorClosed == false)
            {
                doorAnimator.Play("closeDoor");
                doorClosed = true;
                if(doorNumber == 1)
                {
                    resourcesManager.GetComponent<Energy>().leftDoorOn = true;
                }
                else if (doorNumber == 2)
                {
                    resourcesManager.GetComponent<Energy>().rightDoorOn = true;
                }
            }
            else if(doorClosed == true)
            {
                doorAnimator.Play("openDoor");
                doorClosed = false;
                resourcesManager.GetComponent<Energy>().leftDoorOn = true;
                if (doorNumber == 1)
                {
                    resourcesManager.GetComponent<Energy>().leftDoorOn = false;
                }
                else if (doorNumber == 2)
                {
                    resourcesManager.GetComponent<Energy>().rightDoorOn = false;
                }
            }
        }
    }

    private void OnMouseEnter()
    {
        isMouseOver = true;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
    }
}
