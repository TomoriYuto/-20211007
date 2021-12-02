using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//#if UNITY_EDITOR
using UnityEditor;
public class PouseEnd : MonoBehaviour
{
    public void GameEnd()
    {
        StartCoroutine(GameEndScene());
    }

    IEnumerator GameEndScene()
    {
        yield return new WaitForSeconds(1.0f);
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();

    }
}
//#endif