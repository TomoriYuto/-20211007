using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//スクリプトでUI(テキストなど)扱うときはこれ必須！！
using UnityEngine.SceneManagement;

public class Menusound : MonoBehaviour
{
    public int It = 0;
    public int i = 0;

    private AudioSource audio;
    private AudioSource audio2;

    [SerializeField]
    public AudioClip sound;
    public AudioClip sound2;

    //スタート関数
    void Start()
    {
        audio = gameObject.AddComponent<AudioSource>();
        audio2 = gameObject.AddComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxisRaw("Vertical");

        if (y == +1 || y == -1)
        {
            if (i == 0)
            {
                Puro();
                i++;
            }
        }
        else
        {
            i = 0;
        }
        if (Input.GetKeyDown("joystick button 0"))
        {
            audio2.PlayOneShot(sound2);

        }

    }

    public void Puro()
    {
        float y = Input.GetAxisRaw("Vertical");

        if (y == -1 && It != 2)
        {
                
            It++;
            audio.PlayOneShot(sound);
        }
        else if (y == -1)
        {
      
            It = 0;
            audio.PlayOneShot(sound);
        }

        if (y == +1 && It != 0)
        {
     
            It--;
            audio.PlayOneShot(sound);
        }
        else if (y == +1)
        {
  
            It = 2;
            audio.PlayOneShot(sound);
        }
    }
}
