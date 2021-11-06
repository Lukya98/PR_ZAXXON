using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocimetro : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    bool moving = true;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        float tt = Time.time;
        if (moving)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        if (tt >= 10)
        {
            moving = false;
            print("Mi posición en Z es" + transform.position.z);
        }
        else
        {
            print(Mathf.Round(tt));
        }
    }
}
