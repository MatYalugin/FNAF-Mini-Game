using UnityEngine;
using UnityEngine.UI;

public class TabletManager : MonoBehaviour
{
    public Image background;
    public Sprite leftHoleSprite;
    public Sprite rightHoleSprite;

    public void switchLeftHole()
    {
        background.sprite = leftHoleSprite;
    }
    public void switchRightHole()
    {
        background.sprite = rightHoleSprite;
    }
}

