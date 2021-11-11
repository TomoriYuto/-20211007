using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    [SerializeField]
    private Text _Textcountdown;

    [SerializeField]
    private Image _imageMask;

    void Start()
    {
        _Textcountdown.text = "";
    }

    public void OnClickButtonStart()
    {
        StartCoroutine(CountdownCoroutine());
    }

    IEnumerator CountdownCoroutine()
    {
        _imageMask.gameObject.SetActive(true);
        _Textcountdown.gameObject.SetActive(true);

        _Textcountdown.text = "3";
        yield return new WaitForSeconds(1.0f);

        _Textcountdown.text = "2";
        yield return new WaitForSeconds(1.0f);

        _Textcountdown.text = "1";
        yield return new WaitForSeconds(1.0f);

        _Textcountdown.text = "GO!";
        yield return new WaitForSeconds(1.0f);

        _Textcountdown.text = "";
        _Textcountdown.gameObject.SetActive(false);
        _imageMask.gameObject.SetActive(false);
    }
}