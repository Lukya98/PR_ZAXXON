using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{
    public float JuegoSpeed;
    public bool alive;

    public int lives;
    

    // Start is called before the first frame update
    void Start()
    {
        JuegoSpeed = 30f;
        alive = true;
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
