using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    private int ScoreNum;
    public GameObject dinosaurs;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        //ScoreText = "J1 : " + ScoreNum;
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void onTriggerEnter2D (Collider2D Nest)
    {
        ScoreNum += 1;
        Destroy(dinosaurs);
        ScoreText.text = "Score" + ScoreNum;
    }
}
