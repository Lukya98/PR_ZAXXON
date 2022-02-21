using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Slider : MonoBehaviour
{
    [SerializeField] Text volumentext;
    float volumen;
    [SerializeField] Slider myslider;
    AudioSource musicvolume;
    
    void Start()
    {
        musicvolume = GameObject.Find("Canvas").GetComponent<AudioSource>();
        myslider.GetComponent<Slider>();
        //myslider.Value;

        //No consigo que me detecte el Value del slider


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
