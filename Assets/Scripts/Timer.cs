using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

[SerializeField]
public class Timer : MonoBehaviour
{
    public float currentTime = 0f;    
    public float startingTime = 60f;
    //public float restartDelay = false;
    [SerializeField] Text countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString ("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene ("ScoreScene");
            print ("Fin de la partie");
        }
    }
}
