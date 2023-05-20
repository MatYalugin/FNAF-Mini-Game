using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExtraNightsUnlock : MonoBehaviour
{
    public bool saving = true;
    public int nightToSave = 1;
    private int nightSaved;
    public Button hardNightButton;
    public Button unrealNightButton;
    // Start is called before the first frame update
    void Start()
    {
        if (saving == false)
        {
            unlockNightInMainMenu();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void saveNight()
    {
        PlayerPrefs.SetInt("lastNight", nightToSave);
    }
    public void unlockNightInMainMenu()
    {
        nightSaved = PlayerPrefs.GetInt("lastNight");
        if(nightSaved == 1)
        {
            hardNightButton.interactable = true;
        }
        if (nightSaved == 2)
        {
            hardNightButton.interactable = true;
            unrealNightButton.interactable = true;
        }
    }
    public void clearStats()
    {
        PlayerPrefs.DeleteAll();
    }
}
