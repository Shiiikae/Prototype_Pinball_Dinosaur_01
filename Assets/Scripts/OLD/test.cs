using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject dinos;
    public float dinosaurSpeed = 2f;
    public float countdownTransform = 2f;
    public float inputTimer = 0f;
    public bool inputBool;

    public float TimerRight01, TimerRight02, TimerLeft01, TimerLeft02, TimerUp01, TimerUp02, TimerUp03, TimerUp04;

    public bool BoolRight01 = false;
    public bool BoolRight02 = false;
    public bool BoolLeft01 = false;
    public bool BoolLeft02 = false;
    public bool BoolUp01 = false;
    public bool BoolUp02 = false;
    public bool BoolUp03 = false;
    public bool BoolUp04 = false;

    public float posX, posY;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // autant de Bool et Timer que de boutons = ok
    //dans chaque partie faire condition du bouton
    // + ajout posX et Y dans chaque "if"  de la partie translate

    // Update is called once per frame
    void Update()
    {

        posX = transform.position.x;
        posY = transform.position.y;

        //LEFT KEY
            //BOUTON DU HAUT 01
            
        if (Input.GetKey(KeyCode.E))
        {
            BoolLeft01 = true;
            //inputTimer -= 1 * Time.deltaTime;
            //transform.Translate (-dinosaurSpeed * Time.deltaTime, 0, 0);
        }
        else
        {
            BoolLeft01 = false;
        }

            // BOUTON DU HAUT 02
        if (Input.GetKey(KeyCode.R))
        {
            BoolLeft02 = true;
            //inputTimer -= 1 * Time.deltaTime;
            //transform.Translate (-dinosaurSpeed * Time.deltaTime, 0, 0);
        }
        else
        {
            BoolLeft02 = false;
        }

        //RIGHT KEY
            // BOUTON DROIT 01
        if (Input.GetKey(KeyCode.O)) //droite
        {
            BoolRight01 = true;
            //inputTimer -= 1 * Time.deltaTime;
            //transform.Translate (+dinosaurSpeed * Time.deltaTime, 0, 0);
        }
        else 
        {
            BoolRight01 = false;
        }

           // BOUTON DROIT 02
        if (Input.GetKey(KeyCode.P)) //droite
        {
            BoolRight02 = true;
            //inputTimer -= 1 * Time.deltaTime;
            //transform.Translate (+dinosaurSpeed * Time.deltaTime, 0, 0);
        }
        else 
        {
            BoolRight02 = false;
        }        

        //UP KEY
             //BOUTON DU HAUT 01
        if (Input.GetKey(KeyCode.T))
        {
            BoolUp01 = true;
            //inputTimer -= 1 * Time.deltaTime;
            //transform.Translate (0, +dinosaurSpeed * Time.deltaTime, 0);
        }
        else 
        {
            BoolUp01 = false;
        }

            //BOUTON DU BAS 02
        if (Input.GetKey(KeyCode.Y))
        {
            BoolUp02 = true;
            //inputTimer -= 1 * Time.deltaTime;
            //transform.Translate (0, +dinosaurSpeed * Time.deltaTime, 0);
        }
        else 
        {
            BoolUp02 = false;
        }

             //BOUTON DU BAS 03
        if (Input.GetKey(KeyCode.U))
        {
            BoolUp03 = true;
            //inputTimer -= 1 * Time.deltaTime;
            //transform.Translate (0, +dinosaurSpeed * Time.deltaTime, 0);
        }
        else 
        {
            BoolUp03 = false;
        }       

            //BOUTON DU BAS 04
        if (Input.GetKey(KeyCode.I))
        {
            BoolUp04 = true;
            //inputTimer -= 1 * Time.deltaTime;
            //transform.Translate (0, +dinosaurSpeed * Time.deltaTime, 0);
        }
        else 
        {
            BoolUp04 = false;
        }


        //TIMER
        if (BoolUp01 == true)
        {
            TimerUp01 = 2f;
        }

        if (BoolUp02 == true)
        {
            TimerUp02 = 2f;
        }

        if (BoolUp03 == true)
        {
            TimerUp03 = 2f;
        }

        if (BoolUp04 == true)
        {
            TimerUp04 = 2f;
        }

        if (BoolLeft01 == true)
        {
            TimerLeft01 = 2f;
        }

        if (BoolLeft02 == true)
        {
            TimerLeft02 = 2f;
        }

        if (BoolRight01 == true)
        {
            TimerRight01 = 2f;
        }

        if (BoolRight02 == true)
        {
            TimerRight02 = 2f;
        }


        //TRANSLATE
        if (TimerUp01 >= 0 && posX >= 40.4 && posX <= 42.2 && posY >= 60 && posY <= 63)
        {
           TimerUp01 -= 1 * Time.deltaTime;
           transform.Translate (-dinosaurSpeed * Time.deltaTime, 0, 0);
           Debug.Log("yes");
        }

        if (TimerUp02 >= 0 && posX >= 40.4 && posX <= 42.2 && posY >= 60 && posY <= 63)
        {
           TimerUp02 -= 1 * Time.deltaTime;
           transform.Translate (-dinosaurSpeed * Time.deltaTime, 0, 0);
           Debug.Log("yes");
        }

         if (TimerUp03 >= 0 && posX >= 40.4 && posX <= 42.2 && posY >= 60 && posY <= 63)
        {
           TimerUp03 -= 1 * Time.deltaTime;
           transform.Translate (-dinosaurSpeed * Time.deltaTime, 0, 0);
           Debug.Log("yes");
        }

        if (TimerUp04 >= 0 && posX >= 40.4 && posX <= 42.2 && posY >= 60 && posY <= 63)
        {
           TimerUp04 -= 1 * Time.deltaTime;
           transform.Translate (-dinosaurSpeed * Time.deltaTime, 0, 0);
           Debug.Log("yes");
        }

        if (TimerRight01 >= 0)
        {
            TimerRight01 -= 1 * Time.deltaTime;
            transform.Translate (+dinosaurSpeed * Time.deltaTime, 0, 0);
        }

        if (TimerRight02 >= 0)
        {
            TimerRight02 -= 1 * Time.deltaTime;
            transform.Translate (+dinosaurSpeed * Time.deltaTime, 0, 0);
        }

        if (TimerLeft01 >= 0 && posX >= 42.48 && posX <= 43.94 && posY >= 65.21 && posY <= 66.98)
        {
            TimerLeft01 -= 1 * Time.deltaTime;
            transform.Translate (0, -dinosaurSpeed * Time.deltaTime, 0);
        }

        if (TimerLeft02 >= 0)
        {
            TimerLeft02 -= 1 * Time.deltaTime;
            transform.Translate (0, -dinosaurSpeed * Time.deltaTime, 0);
        }

        //SPRITE
        if (TimerUp01 >= 0)
        {
           //launch sprite
        }


        Debug.Log ("posX = "+ posX + "posY = " + posY);
    }
}
