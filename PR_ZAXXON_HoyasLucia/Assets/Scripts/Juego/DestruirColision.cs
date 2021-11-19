using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirColision : MonoBehaviour
{
    InitGame juego;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Asteroide")
        { 
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        
    }
}
