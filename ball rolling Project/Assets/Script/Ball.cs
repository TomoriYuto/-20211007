using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject ball;
    Vector3 moveDir;    // 移動方向ベクトル
    float speed = 0.2f; // 移動速度

    void Start()
    {
        moveDir = new Vector3(1, -2, 1).normalized * speed;
    }

    void Update()
    {
        // 移動
        transform.position += moveDir;

        // ボールと平面の距離
        Vector3 d = transform.position - ball.transform.position;
        float h = Vector3.Dot(d, ball.transform.up);

        // 当たり判定
        if (h < transform.localScale.x)
        {
            Collision();
        }
    }

    void Collision()
    {
        // 反射ベクトルを計算する
        Vector3 n = ball.transform.up;
        float h = Mathf.Abs(Vector3.Dot(moveDir, n));
        Vector3 r = moveDir + 2 * n * h;
        moveDir = r;
    }
}