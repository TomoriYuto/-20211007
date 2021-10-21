using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decelerate : MonoBehaviour
{
    void FixedUpdate()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
        Vector3 force = new Vector3(0.0f, 0.0f, 1.0f);    // 力を設定
        rb.AddForce(force);  // 力を加える
    }
}