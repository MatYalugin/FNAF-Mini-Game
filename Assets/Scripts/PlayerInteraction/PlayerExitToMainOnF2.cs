using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerExitToMainOnF2 : MonoBehaviour
{
    public int mainMenuIndex = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F2))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(mainMenuIndex);
        }
    }
}
