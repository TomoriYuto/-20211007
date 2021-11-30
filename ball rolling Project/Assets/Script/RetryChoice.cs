using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RetryChoice : MonoBehaviour
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

    }
}
