using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_stuff : MonoBehaviour
{
    public AudioSource musicSource;
    Animator anim;
    public AudioClip musicClipOne;
    public AudioClip musicClipTwo;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            musicSource.clip = musicClipOne;
            musicSource.Play();
            //sets state to walk(1)
            anim.SetInteger("State", 1);

        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            musicSource.Stop();
            //sets state to idle (0)
            anim.SetInteger("State", 0);
        }
        
    //BREAK

        if (Input.GetKeyDown(KeyCode.R))
        {
            musicSource.clip = musicClipTwo;
            musicSource.Play();
            //sets state to run (2)
            anim.SetInteger("State", 2);
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            musicSource.Stop();
            //sets state to idle (0)
            anim.SetInteger("State", 0);
        }

        //ESCAPE
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

    }
}
