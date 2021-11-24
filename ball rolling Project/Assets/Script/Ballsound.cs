using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballsound : MonoBehaviour
{
    private AudioSource audio;

    [SerializeField]
    private AudioClip sound;
    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.AddComponent<AudioSource>();
    }

    /// <summary>
	/// 衝突した時
	/// </summary>
	/// <param name="collision"></param>
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Floar")
        {
            Debug.Log(77);
            audio.PlayOneShot(sound);
        }
    }
}
