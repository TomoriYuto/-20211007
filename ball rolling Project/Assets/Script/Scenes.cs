using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            StartCoroutine(GameStartScene());
        }
    }
    IEnumerator GameStartScene()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("SampleScene");
    }

}
