using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public GameObject dinosaur;
    public Rigidbody2D rbody;
    public float speed = 1f;
    public float countdownMovement = 2f;
    public float timerInput = 0f;
    public bool timerInputBool = false;

    public bool movement;

    // Start is called before the first frame update
    void Start()
    {
        //rbody = GetComponents<Rigidbody2D>();
        //movement = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timerInputBool);
       if (Input.GetKey(KeyCode.A))
       {
           timerInputBool = true;
           timerInput = 2f;
           /*if (timerInput <= 2 && timerInput > 0)
           {
               DinosaurMovement();
           }

            movement = true;
            //DinosaurMovement();*/
       }

       if(timerInputBool == true)
       {
           timerInput -= 1* Time.deltaTime;
           DinosaurMovement();
       }

       if (timerInput <= 0)
       {
           timerInputBool = false;
       }
    }

    void DinosaurMovement()
    {
        countdownMovement -= 1* Time.deltaTime;
        if (countdownMovement <= 2)
        {
            transform.Translate (-speed * Time.deltaTime, 0, 0);
        }

        if (countdownMovement <= 0)
        {
            countdownMovement = 0;
            speed = 0;
        }
    }   
    /*void DinosaurMovement2()
    {
        countdownMovement -= 1* Time.deltaTime;
        if (countdownMovement <= 2)
        {
            transform.Translate (+speed * Time.deltaTime, 0, 0);
        }

        if (countdownMovement <= 0)
        {
            countdownMovement = 0;
            speed = 0;
        }
    }*/
}