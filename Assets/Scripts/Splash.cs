using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{

    [SerializeField] private float waitTime = 11f;

    void Start () 
    {
        StartCoroutine(streamVideo());
    }

    private IEnumerator streamVideo()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene("Login Scene");
    }
}