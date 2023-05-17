using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WonOrLoseMenu : MonoBehaviour
{
    public float delay;
    private void Start()
    {
        Invoke("ChangeLevel", delay);
    }
    public void ChangeLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
