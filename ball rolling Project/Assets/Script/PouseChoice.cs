using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PouseChoice : MonoBehaviour
{
    public Button button;
    public Button button2;
    public RectTransform a;

    void OnEnable()
    {
        button2.GetComponent<Button>().Select();
        //button = GameObject.Find("menu/Panel/re").GetComponent<Button>();
        //ボタンが選択された状態になる
        button.GetComponent<Button>().Select();
        Debug.Log("aaa");

    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown("joystick button 10"))
    //    {
    //        a.position += new Vector3(1f + 1, 0, 0);
    //    }
    //}
}
