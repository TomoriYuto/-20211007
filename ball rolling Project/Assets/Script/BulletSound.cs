using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSound : MonoBehaviour
{
    public AudioClip audio;

    // Start is called before the first frame update
    void Start()
    {

    }

    /// <summary>
    /// 衝突した時
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter(Collider hit)
    {
        //接触対象はPlayerか
        if (hit.CompareTag("Ball"))
        {
            AudioSource.PlayClipAtPoint(audio, transform.position);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
