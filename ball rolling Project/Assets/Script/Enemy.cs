using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject muzzlePoint;
    public GameObject ball;
    public float speed = 10f;
    private int attackTime = 0;
    public int intvalTime = 30;
    public GameObject target;
    private bool inArea = false;
    //public GameObject bullethit;

    // Update is called once per frame
    void Update()
    {
        attackTime += 1;
        if(attackTime % intvalTime == 0)
        {
            EneCannonShot();
        }
    }

    public void EneCannonShot()
    {
        if(target.activeInHierarchy == false)
        {
            inArea = false;
        }

        if(inArea == true)
        {
            Vector3 mballPos = muzzlePoint.transform.position;
            GameObject newBall = Instantiate(ball, mballPos, transform.rotation);
            Vector3 dir = muzzlePoint.transform.forward;

            newBall.GetComponent<Rigidbody>().AddForce(dir * speed, ForceMode.Impulse);
            newBall.name = ball.name;
            Destroy(newBall, 1.0f);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.transform.position - transform.position), Time.deltaTime * 3.0f);

            inArea = true;
            target = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            inArea = false;
        }
    }
}