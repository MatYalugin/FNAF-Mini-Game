using UnityEngine;
using UnityEngine.UI;

public class TabletManager : MonoBehaviour
{
    public Image background;
    public Sprite leftHallSprite;
    public Sprite rightHallSprite;

    public Sprite rightHallChicaSprite;
    public Sprite leftHallBonnieSprite;

    public bool ChicaOnCam;
    public bool BonnieOnCam;

    public Sprite startWhiteNoise;
    public GameObject cameraMush;

    public AudioSource camSwitchAudio;

    public void switchLeftHall()
    {
        background.sprite = leftHallSprite;
        cameraMush.SetActive(true);
        if (BonnieOnCam == true)
        {
            background.sprite = leftHallBonnieSprite;
        }
        Invoke("cameraMushDisappear", 0.25f);
        camSwitchAudio.Play();
    }
    public void switchRightHall()
    {
        background.sprite = rightHallSprite;
        cameraMush.SetActive(true);
        if (ChicaOnCam == true)
        {
            background.sprite = rightHallChicaSprite;
        }
        Invoke("cameraMushDisappear", 0.25f);
        camSwitchAudio.Play();
    }
    public void setChicaOnRightHall()
    {
        if(background.sprite == rightHallSprite)
        {
            background.sprite = rightHallChicaSprite;
        }
    }
    public void removeChicaOnRightHall()
    {
        if (background.sprite == rightHallChicaSprite)
        {
            background.sprite = rightHallSprite;
        }
    }

    public void setBonnieOnLeftHall()
    {
        if(background.sprite == leftHallSprite)
        {
            background.sprite = leftHallBonnieSprite;
        }
    }
    public void removeBonnieOnLeftHall()
    {
        if (background.sprite == leftHallBonnieSprite)
        {
            background.sprite = leftHallSprite;
        }
    }
    public void cameraMushDisappear()
    {
        cameraMush.SetActive(false);
    }
}

