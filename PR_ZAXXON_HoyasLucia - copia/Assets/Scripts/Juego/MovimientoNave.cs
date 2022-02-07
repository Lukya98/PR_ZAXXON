using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    [SerializeField] float speed;
    public GameObject nave;
    public InitGame iniciojuego;
   // AudioSource audiosource;

    
    
    
    float desplH;
    float desplV;
    float desplR;

    // Start is called before the first frame update
    void Start()
    {
        speed = 8;
        //audiosource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        MoverNave();
       
    }
    void MoverNave()
    {
        float posX = transform.position.x;
        float posY = transform.position.y;
        float limiteH = 12f;
        float limiteV = 10f;
        float limiteV2 = 0.5f;

        float desplH = Input.GetAxis("Horizontal");
        float desplV = Input.GetAxis("Vertical");

        //movimiento de la nave
        //horizontal
        if ((posX < limiteH || desplH < 0f) && (posX > -limiteH || desplH > 0f))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplH, Space.World);
        }

        //vertical

        if ((posY < limiteV || desplV < 0f) && (posY > limiteV2 || desplV > 0f))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplV, Space.World);
        }
        //restricciones de la nave
        //la nave tiene que moverse entre -5 y +5 en el eje horizontal como maximo.
        //la nave tiene que moverse entre 0.5 y 5 en el eje vertical como maximo


    }
    void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Asteroide") && (iniciojuego.lives == 0))
        {
            GameObject.Find("nave").GetComponent<Renderer>().enabled = false;

        }

    }
    public void Chocar()
    {
        speed = 0;
        iniciojuego.alive = false;
    }
   /*ublic void DispararSound()
    {
        audiosource.Play();
    }*/

}
