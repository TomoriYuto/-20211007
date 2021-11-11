using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallsound : MonoBehaviour
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
    private void OnCollisionEnter(Collision　other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Debug.Log("壁にぶつから真");
            audio.PlayOneShot(sound);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
