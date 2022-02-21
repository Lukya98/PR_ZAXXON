using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirColision : MonoBehaviour
{
    InitGame initgame;
    SonidoExplosionAsteroide sonidoexplosion;
  //  [SerializeField] GameObject particles;
    
    // Start is called before the first frame update
    void Start()
    {
        initgame = GameObject.Find("InitGame").GetComponent<InitGame>();
        sonidoexplosion = GameObject.Find("ExplosionAsterioides Sound").GetComponent<SonidoExplosionAsteroide>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Asteroide")
        {
          //  print("pum");
            sonidoexplosion.puede_pum = true;
            Destroy(gameObject);
            Destroy(other.gameObject);
            initgame.score_adapt= initgame.score_adapt +10;
            //Instantiate(particles, transform);
        }
        
    }
}
