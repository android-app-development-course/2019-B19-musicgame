using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    int hour;
    int minute;
    int second;
    int millisecond;

    float timeSpend = 0.0f;

   


	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        timeSpend += Time.deltaTime;
        
        hour = (int)timeSpend / 3600;
        minute = ((int)timeSpend - hour * 3600) / 60;
        second = (int)timeSpend - hour * 3600 - minute * 60;
        millisecond = (int)((timeSpend - (int)timeSpend) * 1000);
       
    }
    //public void shouw_Time()
    //{
    //    GameObject.Find("Canvas/time").GetComponent<Text>().text = "444";
    //}



    //public void GameStop()
    //{
    //    Time.timeScale = 0;
    //}
    //public void GameGoon()
    //{
    //    Time.timeScale = 1;
    //}
}
