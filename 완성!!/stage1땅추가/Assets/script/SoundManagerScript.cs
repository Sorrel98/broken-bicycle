using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip jumpsound;
    static AudioSource audiosrc;
    // Start is called before the first frame update
    void Start()
    {
        jumpsound = Resources.Load<AudioClip>("JUMP");


        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public static void PlaySound(string clip) 
    {
        switch (clip) 
        {
            case "JUMP":
                audiosrc.PlayOneShot(jumpsound);
                break;
        }
    }

}
