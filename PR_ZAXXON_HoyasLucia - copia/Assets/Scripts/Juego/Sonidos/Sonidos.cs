using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
   
    AudioSource audiosource;
    
    
    [SerializeField] AudioClip disparosound;
    InitGame initgame;
    

   // [SerializeField] AudioClip chichos;
   // AudioClip fondosound;
    // Start is called before the first frame update
    void Start()
    {
       
        audiosource = GetComponent<AudioSource>();
        initgame = GameObject.Find("InitGame").GetComponent<InitGame>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")&&initgame.alive)
            {
            audiosource.PlayOneShot(disparosound, 0.7f);
            }


       
    }
}
