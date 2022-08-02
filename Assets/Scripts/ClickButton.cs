using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Image  _img;
    [SerializeField] private Sprite  _default, _pressed;
    // [SerializeField] private AudioClip  _compressClip, _uncompressClip;
    // [SerializeField] private AudioSource  _source;

    public void OnPointerDown(PointerEventData eventData)
    {
        _img.sprite = _pressed;
    }

    //Detect if clicks are no longer registering
    public void OnPointerUp(PointerEventData eventData)
    {
        _img.sprite = _default;
    }

    // public void ChangeScene(string sceneName)
    // {
    //     SceneManager.LoadScene(sceneName);
    // }
}
