using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Initmenu : MonoBehaviour
{
    //[SerializeField] Text volumenText;
    // float volumen;
    // [SerializeField] Slider mySlider;
    InitGame initgame;
    [SerializeField] Image lifesImage;
    [SerializeField] Sprite[] lifesSprite;


    //Textos
    [SerializeField] Text scoretext;

    [SerializeField] Text finalscoretext;
    // Start is called before the first frame update
    void Start()
    {
        // volumenText.text = "Volumen:" + mySlider.value;
        initgame = GameObject.Find("InitGame").GetComponent<InitGame>();

        


    }


    // Update is called once per frame
    void Update()
    {
        int lifes = initgame.lives;
        lifesImage.sprite = lifesSprite[lifes];
        if (lifes<= 0)
        {
            GameObject.Find("CanvasHUD").GetComponent<Canvas>().enabled = false;
        }

        //Texto score
        scoretext.text = ("Score: ") + initgame.score_adapt;

        finalscoretext.text = ("Final Score: ") + initgame.score_adapt;
    }
    
    
    
    
    
    
    
    public void Play()
    {
        SceneManager.LoadScene("Escena_1");
    }
    public void Settings()
    {
        SceneManager.LoadScene("ConfigGame");
    }
    public void HighScore()
    {
        SceneManager.LoadScene("Highscore");
    }
    public void Exit()
    {
        Application.Quit();
    }
    /*public void SubirVolumen()
    {
       volumen = (mySlider.value);
        volumenText.text = "Volumen:" + volumen;
    }*/
    public void Back()
    {
        SceneManager.LoadScene("Inicio");
    }

}
