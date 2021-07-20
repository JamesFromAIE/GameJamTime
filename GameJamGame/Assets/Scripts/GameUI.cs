using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public int score = 0;
    public float timer = 30f;
    public int survivorNumber;

    public Text scoreText;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        survivorNumber = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;

        timer = (Mathf.Round(timer * 100) / 100);
   
        // When the level is beat
        if (survivorNumber == 0)
        {
            SceneManager.LoadScene("EventHandler");

            score++;

            timer = 30;
        }

        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        timerText.text = "Time Left: " + timer;
    }
}
