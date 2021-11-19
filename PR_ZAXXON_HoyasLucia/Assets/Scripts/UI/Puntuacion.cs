using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    InitGame iniciojuego;
    public Text puntuacion;

    // Start is called before the first frame update
    void Start()
    {
        iniciojuego = GameObject.Find("InitGame").GetComponent<InitGame>();
        

        
    }

    // Update is called once per frame
    void Update()
    {
        puntuacion.text = "score" + iniciojuego.score;

    }
}
