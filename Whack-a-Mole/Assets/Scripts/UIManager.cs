using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;



public class UIManager : MonoBehaviour
{
    public bool timerStarted = false;
    public float currentTime;
    [SerializeField] TMP_Text timer;
    public bool gameisover = false;
    public Parent parent;
    public int score;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text scoreTextEnd;
    public GameObject panel;
    


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timerStarted)
        {
            currentTime = currentTime - Time.deltaTime;
            if(currentTime <= 0)
            {
                gameisover = true;
                currentTime = 0;
                panel.SetActive(true);
                scoreTextEnd.text = "Your Score  " + score.ToString();
                    
            }
            timer.text = "Time: " + currentTime.ToString("f1");

            scoreText.text = "Score: " + score.ToString();
        }
        

    }

    public void restart()
    {
        SceneManager.LoadScene(0);
    }
}
