using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoChoquenave : MonoBehaviour
{

    AudioSource audiosource;

    [SerializeField] AudioClip explosionnave;
    public bool puede_chocar;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (puede_chocar == true)
        {
            audiosource.PlayOneShot(explosionnave, 1f);
            puede_chocar = false;
        }
    }
}

