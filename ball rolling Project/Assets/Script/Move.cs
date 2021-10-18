using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(30 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-30 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0, 0, -30 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(0, 0, 30 * Time.deltaTime);
        }
    }
}
//        // 前に移動
//        if (Input.GetKey(KeyCode.DownArrow))
//    {
//        this.transform.Translate(-0.1f, 0.0f, 0.0f);
//    }
//    // 後ろに移動
//    if (Input.GetKey(KeyCode.UpArrow))
//    {
//        this.transform.Translate(0.1f, 0.0f, 0.0f);
//    }
//    // 左に移動
//    if (Input.GetKey(KeyCode.LeftArrow))
//    {
//        this.transform.Translate(0.0f, 0.0f, 0.1f);
//    }
//    // 右に移動
//    if (Input.GetKey(KeyCode.RightArrow))
//    {
//        this.transform.Translate(0.0f, 0.0f, -0.1f);
//    }
//}


