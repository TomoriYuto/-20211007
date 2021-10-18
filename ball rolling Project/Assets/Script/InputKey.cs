using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown("joystick Button 0"))
        //{
        //    Debug.Log("Button0");
        //}
        if (Input.GetKey("joystick button 1"))
        {
            Debug.Log("button1");
        }
        if (Input.GetKey("joystick button 2"))
        {
            Debug.Log("button2");
        }
        if (Input.GetKey("joystick button 3"))
        {
            Debug.Log("button3");
        }
        if (Input.GetKey("joystick button 4"))
        {
            Debug.Log("button4");
        }
        if (Input.GetKey("joystick button 5"))
        {
            Debug.Log("button5");
        }
        if (Input.GetKey("joystick button 6"))
        {
            Debug.Log("button6");
        }
        if (Input.GetKey("joystick button 7"))
        {
            Debug.Log("button7");
        }
        if (Input.GetKey("joystick button 8"))
        {
            Debug.Log("button8");
        }
        if (Input.GetKey("joystick button 9"))
        {
            Debug.Log("button9");
        }
        float hori = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        if ((hori != 0) || (vert != 0))
        {
            Debug.Log("stick:" + hori + "," + vert);
        }

    }
}


