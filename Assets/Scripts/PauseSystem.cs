using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PauseSystem : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject pauseMenu;
    public GameObject camera;
    
    public Button crewCard; 
    public Button crewCard1;
    public Button crewCard2;
    public Button crewCard3;
    public Button crewCard4;
    public Button crewCard5;

    public Button upgradeButton;

    void Update () {
        if (Input.GetButtonDown("Cancel"))
        {
            if(gamePaused == false)
            {
                Time.timeScale = 0;
                gamePaused = true;

                // Show pause menu
                pauseMenu.SetActive(true);

                // Disable crew card
                crewCard.enabled = false;
                crewCard1.enabled = false;
                crewCard2.enabled = false;
                crewCard3.enabled = false;
                crewCard4.enabled = false;
                crewCard5.enabled = false;

                // Disable upgrade button
                upgradeButton.enabled = false;

                // disable camera movement
                camera.GetComponent<CameraMovement>().enabled = false;

                // pause audio
                //AudioListener.pause = true;
            }
            else
            {
                pauseMenu.SetActive(false);
                gamePaused = false;
                Time.timeScale = 1;

                // Enable crew card
                crewCard.enabled = true;
                crewCard1.enabled = true;
                crewCard2.enabled = true;
                crewCard3.enabled = true;
                crewCard4.enabled = true;
                crewCard5.enabled = true;

                // Enable upgrade button
                upgradeButton.enabled = true;

                // enable camera movement
                camera.GetComponent<CameraMovement>().enabled = true;

                // unpause audio
                //AudioListener.pause = false;
            }
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        gamePaused = true;

        // Show pause menu
        pauseMenu.SetActive(true);

        // Disable crew card
        crewCard.enabled = false;
        crewCard1.enabled = false;
        crewCard2.enabled = false;
        crewCard3.enabled = false;
        crewCard4.enabled = false;
        crewCard5.enabled = false;

        // Disable updgrade button
        upgradeButton.enabled = false;

        // disable camera movement
        camera.GetComponent<CameraMovement>().enabled = false;

        // pause audio
        //AudioListener.pause = true;
    }

    public void UnpauseGame()
    {
        pauseMenu.SetActive(false);
        gamePaused = false;
        Time.timeScale = 1;

        // Enable crew card
        crewCard.enabled = true;
        crewCard1.enabled = true;
        crewCard2.enabled = true;
        crewCard3.enabled = true;
        crewCard4.enabled = true;
        crewCard5.enabled = true;

        // Enable upgrade button
        upgradeButton.enabled = true;

        // enable camera movement
        camera.GetComponent<CameraMovement>().enabled = true;

        // unpause audio
        //AudioListener.pause = false;
    }

    
}
