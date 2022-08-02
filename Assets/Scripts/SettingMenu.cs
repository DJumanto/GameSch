using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Slider musicSlider;
    public Slider effectSlider;

    public Dropdown resolutionDropdown;
    Resolution[] resolutions;
    void Start()
    {
        audioMixer.GetFloat("musicVolume", out float music);
        audioMixer.GetFloat("effectVolume", out float effect);

        musicSlider.value = music;
        effectSlider.value = effect;


        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();
        int current = 0;
        List<string> options = new List<string>();

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (option == (Screen.currentResolution.width + " x " + Screen.currentResolution.height))
            {
                current = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = current;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }


    public void SetVolumeMusic(float volume)
    {
        audioMixer.SetFloat("musicVolume", volume);
    }

    public void SetVolumeEffect(float volume)
    {
        audioMixer.SetFloat("effectVolume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(5 - qualityIndex);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void BackToBefore()
    {
        SceneManager.LoadScene("Game");
    }
}
