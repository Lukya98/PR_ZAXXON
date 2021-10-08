using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientoprefab : MonoBehaviour
{

    float speed;
    public InitGame iniciojuego;

    // Start is called before the first frame update
    void Start()
    {
        iniciojuego = GameObject.Find("InitGame").GetComponent<InitGame>();


    }

    // Update is called once per frame
    void Update()
    {
        speed = iniciojuego.JuegoSpeed;

        transform.Translate(Vector3.back * Time.deltaTime * speed);
        
    }

}
