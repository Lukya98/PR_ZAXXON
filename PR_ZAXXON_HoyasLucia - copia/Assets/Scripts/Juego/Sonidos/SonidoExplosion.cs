using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoExplosion : MonoBehaviour
{
    AudioSource audiosource;
    InitGame initgame;
    [SerializeField] AudioClip explosionmorir;
    bool ya_ha_sonado;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        initgame = GameObject.Find("InitGame").GetComponent<InitGame>();
    }

    // Update is called once per frame
    void Update()
    {
        if (initgame.alive == false && ya_ha_sonado == false)
        {
            audiosource.PlayOneShot(explosionmorir, 10f);
            ya_ha_sonado = true;
        }


        if (initgame.alive == true)
        {
            ya_ha_sonado = false;
        }
    }
}
