using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSetting : MonoBehaviour
{
    public GameObject settingMenu;

    public void OpenSettings()
    {
        if(settingMenu.activeInHierarchy)
            settingMenu.SetActive(false);
        else
            settingMenu.SetActive(true);
    }
}
