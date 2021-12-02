using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballsound : MonoBehaviour
{
    //玉のRigidbody
    public Rigidbody rigidbody;

    //SE
    public AudioSource audio;

    void FixedUpdate()
    {
        //玉の速度が0.1(速度の2乗が0.01)以上の時
        if (rigidbody.velocity.sqrMagnitude >= 0.01f)
        {
            //SEが再生していなかったら
            if (!audio.isPlaying)
            {
                //SEを再生
                audio.Play();
            }
        }
        //SEが再生されていたら
        else if (audio.isPlaying)
        {
            //SEを停止
            audio.Pause();
        }
    }
}
