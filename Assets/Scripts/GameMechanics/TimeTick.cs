using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimeTick : MonoBehaviour
{
    public Text timeText;
    private bool nightEnd;
    public int wonMenuIndex;
    // Start is called before the first frame update
    void Start()
    {
        timeText.text = 12 + " AM";
        Invoke("time1PM", 96);
        Invoke("time2PM", 192);
        Invoke("time3PM", 288);
        Invoke("time4PM", 384);
        Invoke("time5PM", 480);
        Invoke("time6PM", 576);

    }
    public void time1PM()
    {
        timeText.text = 1 + " AM";
    }
    public void time2PM()
    {
        timeText.text = 2 + " AM";
    }
    public void time3PM()
    {
        timeText.text = 3 + " AM";
    }
    public void time4PM()
    {
        timeText.text = 4 + " AM";
    }
    public void time5PM()
    {
        timeText.text = 5 + " AM";
    }
    public void time6PM()
    {
        timeText.text = 6 + " AM";
        nightEnd = true;
    }
    public void letNightEnd()
    {
        gameObject.GetComponent<ExtraNightsUnlock>().saveNight();
        Time.timeScale = 1f;
        SceneManager.LoadScene(wonMenuIndex);
    }
    void Update()
    {
        if(nightEnd == true)
        {
            Invoke("letNightEnd", 5);
        }
    }
}
