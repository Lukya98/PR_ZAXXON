using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionesNave : MonoBehaviour
{
    InitGame iniciojuego;

    // Start is called before the first frame update
    void Start()
    {
        iniciojuego = GameObject.Find("InitGame").GetComponent<InitGame>();

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
        }

    }
    
   
}
