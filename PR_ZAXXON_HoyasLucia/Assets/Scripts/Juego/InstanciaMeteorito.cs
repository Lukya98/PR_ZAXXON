using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciaMeteorito : MonoBehaviour
{
    float intervalo;
    [SerializeField] GameObject[]obstaculos; //array de asteorides y posibles obstaculos

    [SerializeField] GameObject meteorito; //Meteorito que se instancia porque aun no estoy usando el array
    [SerializeField] Transform instantiatePos; //Donde quiero que se instancien
    [SerializeField] float distancia; //para hacer la separacion entre meteoritos
    InitGame iniciojuego; //para coger el script de speed

    // Start is called before the first frame update
    void Start()
    {
       // intervalo = 0.5f;

        distancia = 5f;

        iniciojuego = GameObject.Find("InitGame").GetComponent<InitGame>();



        StartCoroutine("CrearMeteorito");
    

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator CrearMeteorito()
    {
        while (true)
        {
            float speed;
            speed = iniciojuego.JuegoSpeed;
            intervalo = distancia / speed;
            //print(intervalo);

            // posicion random en y,x
            float randomY = Random.Range(0.5f, 10f);
            float randomX = Random.Range(-15f, 15f);

            Vector3 newPos = new Vector3(randomX, randomY, instantiatePos.position.z);
            Instantiate(meteorito, newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);
        }
    }
}
