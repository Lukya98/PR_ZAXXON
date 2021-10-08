using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancia : MonoBehaviour
{
    float intervalo;
    [SerializeField] GameObject[]obstaculos;
    [SerializeField] GameObject columna;
    [SerializeField] Transform instantiatePos;
    [SerializeField] float distancia;
    InitGame iniciojuego;

    // Start is called before the first frame update
    void Start()
    {
       // intervalo = 0.5f;
        distancia = 5f;
        iniciojuego = GameObject.Find("InitGame").GetComponent<InitGame>();



        StartCoroutine("CrearColumna");
      /*  float posZcolumna = transform.position.z;
        float posZ = transform.position.z;
        float columnasiniciales = (posZ - posZcolumna) / distancia;

        columnasiniciales = Mathf.Round(columnasiniciales);
        print(columnasiniciales);*/


    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator CrearColumna()
    {
        while (true)
        {
            float speed;
            speed = iniciojuego.JuegoSpeed;
            intervalo = distancia / speed;
            print(intervalo);


            float randomY = Random.Range(0.5f, 10f);
            float randomX = Random.Range(-15f, 15f);
            Vector3 newPos = new Vector3(randomX, randomY, instantiatePos.position.z);
            Instantiate(columna, newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);
        }
    }
}
