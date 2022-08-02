using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPauseSettings : MonoBehaviour
{
    public GameObject settingMenu;
    public GameObject pauseMenu;

    public void OpenSettings()
    {
        settingMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void CloseSettings()
    {
        settingMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }
}
