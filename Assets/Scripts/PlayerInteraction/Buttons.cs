using UnityEngine;

public class Buttons : MonoBehaviour
{
    private bool isMouseOver;
    public Animator doorAnimator;
    public bool doorClosed;
    public GameObject resourcesManager;
    public int doorNumber;
    public Animator buttonAnimator;
    public AudioSource doorAudio;
    private bool isReadyToInteract = true;

    private void OnMouseDown()
    {
        if (isMouseOver)
        {
            if (doorClosed == false && isReadyToInteract == true)
            {
                isReadyToInteract = false;
                Invoke("makeReadyToInteract", 0.45f);
                doorAudio.Play();
                doorAnimator.Play("closeDoor");
                buttonAnimator.Play("buttonPressed");
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
            else if(doorClosed == true && isReadyToInteract == true)
            {
                isReadyToInteract = false;
                Invoke("makeReadyToInteract", 0.45f);
                doorAudio.Play();
                doorAnimator.Play("openDoor");
                buttonAnimator.Play("buttonPressed");
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

    public void makeReadyToInteract()
    {
        isReadyToInteract = true;
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
