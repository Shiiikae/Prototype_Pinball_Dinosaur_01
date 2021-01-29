using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoMovement : MonoBehaviour
{
    public GameObject dinosaurs;
    public GameObject zoneJ1;
    public GameObject zoneJ2;
    public Rigidbody2D rbody;
    
    public float dinosaurSpeed = 3f;
    public float countdownTranslate = 2f;
    public float inputTimer = 0f;

    public bool inputTimerBool;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Bouton01_J2();
        Bouton02_J2();
        Bouton03_J2();
        /*Bouton04_J2();
        Bouton05_J1();
        Bouton06_J1();
        Bouton07_J1();
        Bouton08_J1();*/
    }

    void CharaLeftTranslate()
    {
        countdownTranslate -= 1* Time.deltaTime;
        if (countdownTranslate <= 2)
        {
            transform.Translate (0, -dinosaurSpeed * Time.deltaTime, 0);
        }

        if (countdownTranslate <= 0)
        {
            countdownTranslate = 0;
            dinosaurSpeed = 0;
        }
    }

    void CharaRightTranslate()
    {
        countdownTranslate -= 1* Time.deltaTime;
        if (countdownTranslate <= 2)
        {
            transform.Translate (0, +dinosaurSpeed * Time.deltaTime, 0);
        }

        if (countdownTranslate <= 0)
        {
            countdownTranslate = 0;
            dinosaurSpeed = 0;
        }
    }

    void CharaUpTranslate()
    {
        countdownTranslate -= 1* Time.deltaTime;
        if (countdownTranslate <= 2)
        {
            transform.Translate (0, -dinosaurSpeed * Time.deltaTime, 0);
        }

        if (countdownTranslate <= 0)
        {
            countdownTranslate = 0;
            dinosaurSpeed = 0;
        }
    }

    void Bouton01_J2()
    {
        Debug.Log(inputTimerBool);
        if (Input.GetKey(KeyCode.A))
        {
            inputTimerBool = true;
            inputTimer = 2f;
        }

        if (inputTimerBool == true)
        {
            inputTimer -= 1 * Time.deltaTime;
            CharaLeftTranslate();
        }

        if (inputTimer <= 0)
        {
            inputTimerBool = false;
        }
    }
    void Bouton02_J2()
    {
        if (Input.GetKey(KeyCode.F))
        {
            inputTimerBool = true;
            inputTimer = 2f;
        }

        if (inputTimerBool == true)
        {
            inputTimer -= 1 * Time.deltaTime;
            CharaLeftTranslate();
        }

        if (inputTimer <= 0)
        {
            inputTimerBool = false;
        }
    }
    void Bouton03_J2()
    {
        if (Input.GetKey(KeyCode.G))
        {
            inputTimerBool = true;
            inputTimer = 2f;
        }

        if (inputTimerBool == true)
        {
            inputTimer -= 1 * Time.deltaTime;
            CharaUpTranslate();
        }

        if (inputTimer <= 0)
        {
            inputTimerBool = false;
        }
    }
    /*void Bouton04_J2()
    {
        if (Input.GetKey(KeyCode.R))
        {
            inputTimerBool = true;
            inputTimer = 2f;
        }

        if (inputTimerBool == true)
        {
            inputTimer -= 1 * Time.deltaTime;
            CharaUpTranslate();
        }

        if (inputTimer <= 0)
        {
            inputTimerBool = false;
        }
    }
    void Bouton05_J1()
    {
        if (Input.GetKey(KeyCode.T))
        {
            inputTimerBool = true;
            inputTimer = 2f;
        }

        if (inputTimerBool == true)
        {
            inputTimer -= 1 * Time.deltaTime;
            CharaUpTranslate();
        }

        if (inputTimer <= 0)
        {
            inputTimerBool = false;
        }
    }
    void Bouton06_J1()
    {
        if (Input.GetKey(KeyCode.Y))
        {
            inputTimerBool = true;
            inputTimer = 2f;
        }

        if (inputTimerBool == true)
        {
            inputTimer -= 1 * Time.deltaTime;
            CharaUpTranslate();
        }

        if (inputTimer <= 0)
        {
            inputTimerBool = false;
        }
    }   
    void Bouton07_J1()
    {
        if (Input.GetKey(KeyCode.H))
        {
            inputTimerBool = true;
            inputTimer = 2f;
        }

        if (inputTimerBool == true)
        {
            inputTimer -= 1 * Time.deltaTime;
            CharaRightTranslate();
        }

        if (inputTimer <= 0)
        {
            inputTimerBool = false;
        }
    }
    void Bouton08_J1()
    {
        if (Input.GetKey(KeyCode.I))
        {
            inputTimerBool = true;
            inputTimer = 2f;
        }

        if (inputTimerBool == true)
        {
            inputTimer -= 1 * Time.deltaTime;
            CharaRightTranslate();
        }

        if (inputTimer <= 0)
        {
            inputTimerBool = false;
        }
    }*/
}
