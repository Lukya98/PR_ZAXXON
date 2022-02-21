using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoExplosionAsteroide : MonoBehaviour
{
    AudioSource audiosource;
    
    [SerializeField] AudioClip explosionasteroide;
    public bool puede_pum;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (puede_pum == true)
        {
            audiosource.PlayOneShot(explosionasteroide, 1f);
            puede_pum = false;

           
        }
    }
}
