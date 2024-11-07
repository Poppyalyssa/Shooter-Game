using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject cloud;
    


    public TextMeshProUGUI scoreText;

    private int score;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, transform.position, Quaternion.identity);
        InvokeRepeating("CreateEnemy1", 1f, 3f);
        InvokeRepeating("CreateEnemy2", 5f, 5f);

        CreateSky();
        score = 0;
        scoreText.text = "Score: " + score;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateEnemy1()
    {
        Instantiate(enemy1, new Vector3(Random.Range(-9f, 9f), 7.5f, 0), Quaternion.Euler(0, 0, 180));
    }

    void CreateEnemy2()
    {
        Instantiate(enemy2, new Vector3(9f, Random.Range(0f, 4f), 0), Quaternion.Euler(0, 0, 180));
    }

    void CreateSky()
    {
        for (int i = 0; i < 30; i++)
        {
            Instantiate(cloud, transform.position, Quaternion.identity);
        }
    }

    public void EarnScore(int newScore)
    {
        score += newScore;
        scoreText.text = "Score: " + score;
    }
}