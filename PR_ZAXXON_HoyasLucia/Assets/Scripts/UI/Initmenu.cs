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

    [SerializeField] Image lifesImage;
    [SerializeField] Sprite[] lifesSprite;
    // Start is called before the first frame update
    void Start()
    {
      // volumenText.text = "Volumen:" + mySlider.value;
     //  int lifes = InitGame.lives;
      // lifesImage.sprite = lifesSprite[lifes];


    }



    // Update is called once per frame
    void Update()
    {
        
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
