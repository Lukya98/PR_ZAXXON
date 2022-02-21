using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InitGame : MonoBehaviour
{
    public float JuegoSpeed;
    public bool alive;
    private bool anunciarmuerte;
    //staticas que me rompen el juego 
    public int lives;
    [SerializeField] Image lifesImage;
    [SerializeField] Sprite[] lifesSprite;

    //particulas
    [SerializeField] GameObject particle;
    [SerializeField] Transform particleinstan;
    bool puede_explotar;

    //UI statica que como lo ponga me destruye el juegos
    public static int score;
    public int score_adapt;

    // Start is called before the first frame update
    void Start()
    {
        JuegoSpeed = 30f;
        alive = true;
        lives = 3;
        score = 0;
        
        lifesImage.sprite = lifesSprite[lives];
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0)  //si las vidas son 0 o menos 
        {
            alive = false; //muerto

            if (anunciarmuerte == true)   //mandar mensaje si muerto y es true
            {
                print("Has muerto");
                anunciarmuerte = false;  //no mandar mas mensajes
            }
        }
        else
        {
            alive = true;            // vivo y con posibilidad de mandar mensaje
            anunciarmuerte = true;
        }


        if (alive == false)  // si muerto nave desaparecer
        {
            GameObject.Find("navemesh").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("cristalmesh").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("CanvasGameOver").GetComponent<Canvas>().enabled = true;
            GameObject.Find("EventSystem").GetComponent<EventSystem>().enabled = true;
            
            
            if (puede_explotar)
            {
                Instantiate(particle, particleinstan);
                puede_explotar = false;
            }

        }
        if (alive == true) // si nave viva
        {
            GameObject.Find("CanvasGameOver").GetComponent<Canvas>().enabled = false;
            GameObject.Find("EventSystem").GetComponent<EventSystem>().enabled = false;
            puede_explotar = true;
        }
        score = score_adapt;
        
    }
  

}
