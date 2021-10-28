using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController: MonoBehaviour
{
    //public float speed;
    public Text countText;

    private Rigidbody rb;
    private int count; // アイテムの取得数を格納する変数


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0; // 初期化
        SetCountText();
    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //rb.AddForce(movement * speed);

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
    }
}