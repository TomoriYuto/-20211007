using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
public class PouseEnd : MonoBehaviour
{

    public void GameEnd()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

}
#endif