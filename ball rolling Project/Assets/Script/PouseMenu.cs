using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PouseMenu : MonoBehaviour
{
    [SerializeField] private GameObject Panel;
    private int backP = 0;

    void Start()
    {
        Panel.SetActive(false);

    }
    void Update()
    {

        // スタートボタンを押したらポーズメニューを開く、閉じる
        if (Input.GetKeyDown("joystick button 7") && backP == 0)
        {
            Pause();
            backP++;
            GameObject.Find("Cube/GameObject/cannon").GetComponent<Enemy>().enabled = false;
        }
        else if (Input.GetKeyDown("joystick button 7") && backP == 1)
        {
            Resume();
            backP--;
            GameObject.Find("Cube/GameObject/cannon").GetComponent<Enemy>().enabled = true;
        }
    }
    

    private void Pause()
    {
        GameObject.Find("Cube").GetComponent<RotateCube>().enabled = false;
        GameObject.Find("Ball").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        GameObject.Find("Ball").GetComponent<GameClearResult>().enabled = false;
        //GameObject.Find("bullet").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        Panel.SetActive(true);
    }

    private void Resume()
    {
        GameObject.Find("Ball").GetComponent<GameClearResult>().enabled = true;
        GameObject.Find("Cube").GetComponent<RotateCube>().enabled = true;
        GameObject.Find("Ball").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        //GameObject.Find("bullet").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        Panel.SetActive(false);
    }
}
