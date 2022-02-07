using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
    AudioSource audiosource;
    [SerializeField] AudioClip disparosound;
    [SerializeField] AudioClip chichos;
   // AudioClip fondosound;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.PlayOneShot(chichos);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            {
            audiosource.PlayOneShot(disparosound, 0.7f);
            }
    }
}
