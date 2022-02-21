using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorBala : MonoBehaviour
{
    public GameObject bala;
    public Transform pistola;
    AudioSource audiosource;
    InitGame initgame;

    


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
            
           Instantiate(bala,transform.position,bala.transform.rotation);
           // audiosource.Play();
        }
        
    }
}
