using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    float timer;    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            LoadScreen();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            LoadScreen();
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            LoadScreen();
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            LoadScreen();
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            LoadScreen();
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            LoadScreen();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            LoadScreen();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            LoadScreen();
        }
    }

    public void LoadScreen()
    {
        SceneManager.LoadScene("LoadScene"); //load screen scene
        print ("La scène charge !");
    }
}
