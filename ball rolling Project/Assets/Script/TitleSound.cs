using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSound : MonoBehaviour
{
    private AudioSource audio2;
    public AudioClip sound2;
    // Start is called before the first frame update
    void Start()
    {
        audio2 = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            audio2.PlayOneShot(sound2);

        }
    }
}
