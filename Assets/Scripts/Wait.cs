using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wait : MonoBehaviour
{
    
    public float wait_time = 11f;
    void Start()
    {
        StartCoroutine(waitforintro());
    }

    IEnumerator waitforintro()
    {
        yield return new WaitForSeconds(wait_time);
        SceneManager.LoadScene(1);
    }
}
