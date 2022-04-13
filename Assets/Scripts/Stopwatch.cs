using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    static float startTime;
    public static bool timerOn = true;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerOn){
            updateTimer();
        }
        
    }

    void updateTimer(){
        float t = Time.time - startTime;
        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        
        timerText.text = minutes + ":" + seconds; 
    }
    public static void stopTimer(){
        timerOn = false;
    }

    public static void startTimer(){
        startTime = Time.time;
        timerOn = true;
    }
}
