using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

    public bool uiOn;
    public GameObject uiOverlay;

	void Start ()
    {
        uiOverlay.SetActive(false);
        uiOn = false;
        Cursor.visible = false;
	}
	

	void Update ()
    {
        if (Input.GetButtonDown("Cancel") && uiOn == false)
        {
            GamePause();
            
        }
        else if (Input.GetButtonDown("Cancel") && uiOn == true)
        {
            GameUnpause();
        }
	}

    public void GamePause()
    {
        Time.timeScale = 0;
        uiOverlay.SetActive(true);
        Cursor.visible = true;
        uiOn = true;
    }

    public void GameUnpause()
    {
        uiOverlay.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1;
        uiOn = false;
    }

    public void GameExit()
    {
        Application.Quit();
    }
}
