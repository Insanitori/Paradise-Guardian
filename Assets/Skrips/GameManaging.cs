using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using System;

public class GameManaging : MonoBehaviour
{
    public TextMeshProUGUI Timer;

    public bool StartGame;
    private float timeRemaining;


    // Start is called before the first frame update
    void Start()
    {
        StartGame = false;
        timeRemaining = 300;
        Timer.text = "???";
    }

    // Update is called once per frame
    void Update()
    {
        if(StartGame)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("You have Won!");
                timeRemaining = 0;
                StartGame = false;
            }

            Timer.text = timeRemaining.ToString();
        }
    }
}
