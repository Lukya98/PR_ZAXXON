using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionesNave : MonoBehaviour
{
    InitGame iniciojuego;
    SonidoChoquenave choquenave;

    // Start is called before the first frame update
    void Start()
    {
        iniciojuego = GameObject.Find("InitGame").GetComponent<InitGame>();
        choquenave = GameObject.Find("Choquenave Sound").GetComponent<SonidoChoquenave>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Asteroide") && (iniciojuego.lives>0))
        {
            iniciojuego.lives--;
            print("vidas: "+ iniciojuego.lives);
            if (iniciojuego.lives > 0)
            {
                choquenave.puede_chocar = true;
            }
            
        }

    }
    
   
}
