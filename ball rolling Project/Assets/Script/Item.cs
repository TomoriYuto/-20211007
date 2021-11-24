
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private AudioSource audio;
    [SerializeField]
    private AudioClip sound;
    [SerializeField] private GameObject a;

    void Start()
    {
        audio = gameObject.AddComponent<AudioSource>();
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
            audio.PlayOneShot(sound);
            //a.SetActive(false);
        }
    }
}
