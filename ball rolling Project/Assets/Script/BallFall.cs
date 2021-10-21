using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFall : MonoBehaviour
{

    private Transform myTransform;
    private Vector3 pos;
    private float Gravity;
    private float totalFallTime = 0f;

    void Start()
    {
        myTransform = GetComponent<Transform>();
        pos = myTransform.position;
        Gravity = -9.81f;
    }

    void Update()
    {
        totalFallTime += Time.deltaTime;
        pos.y += (Gravity * Time.deltaTime) * totalFallTime;         //y座標への加算

        myTransform.position = pos;     //座標を設定
    }
}
