using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    Rusting rusting;
    P2Rusting p2Rusting;
    [SerializeField] GameObject player;
    [SerializeField] GameObject p2Player;

    [SerializeField] float normalCountdown = 1;
    [SerializeField] float rustCountdown = 3;

    float currentTime = 0;
    float startingTime = 300;

    void Awake()
    {
        rusting = player.GetComponent<Rusting>();
        p2Rusting = p2Player.GetComponent<P2Rusting>();
    }

    [SerializeField] TMP_Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        timerText.text = "Time Left:" + currentTime.ToString("0");

        if (rusting.isRusting == true)
        {
            currentTime -= rustCountdown * Time.deltaTime;
        }
        if (rusting.isRusting == false)
        {
            currentTime -= normalCountdown * Time.deltaTime;
        }

        if (p2Rusting.isRusting == true)
        {
            currentTime -= rustCountdown * Time.deltaTime;
        }
        if (p2Rusting.isRusting == false)
        {
            currentTime -= normalCountdown * Time.deltaTime;
        }

        if (currentTime <= 0)
        {
            currentTime = 0;
        }

        RestartLevel();
    }

    void RestartLevel()
    {
        if (currentTime == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
