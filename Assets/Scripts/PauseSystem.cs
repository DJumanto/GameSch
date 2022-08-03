using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseSystem : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject settingMenu;
    public CameraMovement camera;
    public List <Button> crewCards;
    public Button upgradeButton;
    
    void Awake()
    {
        settingMenu.SetActive(false);
    }

    void Update() {
        if (Input.GetButtonDown("Cancel"))
        {
            if(gamePaused == false)
            {
                Time.timeScale = 0;
                gamePaused = true;

                // Show pause menu
                settingMenu.SetActive(true);

                // Disable crew card
                for (int i = 0; i < crewCards.Count; i++)
                    crewCards[i].enabled = false;

                // Disable upgrade button
                upgradeButton.enabled = false;

                // disable camera movement
                camera.enabled = false;

                // pause audio
                //AudioListener.pause = true;
            }
            else
            {
                settingMenu.SetActive(false);
                gamePaused = false;
                Time.timeScale = 1;

                // Enable crew card
                for (int i = 0; i < crewCards.Count; i++)
                    crewCards[i].enabled = true;

                // Enable upgrade button
                upgradeButton.enabled = true;

                // enable camera movement
                camera.enabled = true;
                // unpause audio
                //AudioListener.pause = false;
            }
        }
    }

    public void PauseGame()
    {
        if(!settingMenu.activeInHierarchy)
        {
            Time.timeScale = 0;
            gamePaused = true;
            // Show pause menu
            settingMenu.SetActive(true);
            // Disable crew card
            for (int i = 0; i < crewCards.Count; i++)
                crewCards[i].enabled = false;
            // Disable upgrade button
            upgradeButton.enabled = false;
            // disable camera movement
            camera.enabled = false;
            // pause audio
            //AudioListener.pause = true;
        }
        else
        {
            settingMenu.SetActive(false);
            gamePaused = false;
            Time.timeScale = 1;
            // Enable crew card
            for (int i = 0; i < crewCards.Count; i++)
                crewCards[i].enabled = true;
            // Enable upgrade button
            upgradeButton.enabled = true;
            // enable camera movement
            camera.enabled = true;
            // unpause audio
            //AudioListener.pause = false;
        }
    }
}
