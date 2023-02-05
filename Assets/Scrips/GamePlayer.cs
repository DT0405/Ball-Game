using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayer : MonoBehaviour
{
    public GameObject uiGameOver;
    public Image winer;
    public Image loser;
    public TextMeshProUGUI scoreText;

    public void Start()
    {
        winer.gameObject.SetActive(false);
        loser.gameObject.SetActive(false);
        Utils.score = 0;
    }
    public void GameOver()
    {
        uiGameOver.SetActive(true);
        if (Utils.score == 10)
        {
            winer.gameObject.SetActive(true);
        }
        else
        {
            loser.gameObject.SetActive(true);
        }
    }

     void Update()
    {
        scoreText.text = "" + Utils.score;
    }
}
