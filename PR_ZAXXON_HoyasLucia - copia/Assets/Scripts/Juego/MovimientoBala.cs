using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    

    public float fuerzadisparo ;
    


    // Start is called before the first frame update
    void Start()
    {
        fuerzadisparo = 50;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * fuerzadisparo * Time.deltaTime);
       
      
    }
}
