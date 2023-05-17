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

    public void switchLeftHall()
    {
        background.sprite = leftHallSprite;
        if (BonnieOnCam == true)
        {
            background.sprite = leftHallBonnieSprite;
        }
    }
    public void switchRightHall()
    {
        background.sprite = rightHallSprite;
        if(ChicaOnCam == true)
        {
            background.sprite = rightHallChicaSprite;
        }
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
        background.sprite = rightHallSprite;
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
        background.sprite = leftHallSprite;
    }
}

