using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    GameObject ScoreText = null;
    public int point = 0;

    void Start()
    {
        this.ScoreText = GameObject.Find("ScoreText");
    }

    void Update()
    {
        Text Scoretext = ScoreText.GetComponent<Text>();
        Scoretext.text = "Score:" + point;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag")
        {
            point += 1;
        }
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            point += 3;
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            point += 5;
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            point += 10;
        }
    }
}