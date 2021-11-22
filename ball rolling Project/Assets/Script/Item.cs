
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public AudioClip sound1;

    void Start()
    {

    }

    //void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.tag == "Ball")
    //    {
    //        Debug.Log(77);
    //        audio.PlayOneShot(sound);
    //    }
    //}
    private void OnTriggerEnter(Collider hit)
    {
        //接触対象はPlayerか
        if (hit.CompareTag("Ball"))
        {
            AudioSource.PlayClipAtPoint(sound1, transform.position);

            Destroy(gameObject);
        }
    }
}
