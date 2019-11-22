using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject gameOverLabel;
    public GameObject scoreLabel;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;

    public int score = 0;


    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);
    }

    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void AddScore()
    {
        if (gameOver == true)
            return;

        score++;
        scoreLabel.GetComponent<Text>().text = "SCORE : " + score.ToString();
    }

    public void BirdDead()
    {
        gameOverLabel.SetActive(true);
        gameOver = true;
    }
}
