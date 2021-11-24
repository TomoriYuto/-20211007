using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    private Rigidbody rb;
    private Bounce bounce;
    public float power = 1;    // 発射時の力

    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        bounce = this.GetComponent<Bounce>();
    }

    // Update is called once per framess
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(power, 0, power);
            // 発射時のvelocityを取得
            bounce.afterReflectVero = rb.velocity;
        }
    }
}

