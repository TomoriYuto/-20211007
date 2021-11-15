using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PouseEnd : MonoBehaviour
{
    public void GameEnd()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
