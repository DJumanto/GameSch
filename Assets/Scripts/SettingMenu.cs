using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolumeMusic(float volume)
    {
        audioMixer.SetFloat("musicVolume", volume);
    }

    public void SetVolumeEffect(float volume)
    {
        audioMixer.SetFloat("effectVolume", volume);
    }
}
