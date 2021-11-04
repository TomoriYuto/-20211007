using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count; // アイテムの取得数を格納する変数
    private bool inGame;

    private Text textResult;
    private Text textScore;
    private Text textResultTime;
    void Start()
    {
        inGame = true;
        rb = GetComponent<Rigidbody>();
        count = 0; // 初期化
        SetCountText();
        winText.text = "";

        textResult = GameObject.Find("Game Result").GetComponent<Text>();
        textResultTime = GameObject.Find("Result Time").GetComponent<Text>();
        textScore = GameObject.Find("Result Score").GetComponent<Text>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //rb.AddForce(movement * speed);

        if (inGame)
        {
            Debug.Log(Time.time);   //ゲーム開始からの時間を取得

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            other.gameObject.SetActive(false);
            count = count + 1; // 衝突判定のイベントが発生した際に count の数を１上げる
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = count.ToString() + " / 12";

        if (count >= 12)
        {
            winText.text = "ゲームクリア！";
            Time.timeScale = 0;
            inGame = false;

            //textResult.text;
            //textResultTime.text;
            //textScore.text;
        }
    }
}