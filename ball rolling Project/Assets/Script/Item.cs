
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public AudioClip sound1;

    void Start()
    {

    }
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
