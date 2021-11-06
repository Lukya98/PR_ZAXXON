using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciadorBala : MonoBehaviour
{
    public GameObject bala;
    public Transform pistola;

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetButtonDown("Fire1"))
        {

           Instantiate(bala,transform.position,bala.transform.rotation);
           
        }
        
    }
}
