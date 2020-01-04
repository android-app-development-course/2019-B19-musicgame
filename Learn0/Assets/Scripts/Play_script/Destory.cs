using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destory : MonoBehaviour {
    public float tempTime;
    // Use this for initialization
    Image Image;
    public float FadeTimeTrigger = 0f;
    public float FadeTime = 2f;
    bool fa = false;
    void Start () {
        Image = this.GetComponent<Image>();

    }

    // Update is called once per frame
    void Update () {
        
        if (fa)
        {
            FadeTimeTrigger += (Time.deltaTime-(int)(Time.deltaTime));
            //Double C = Math.Round(FadeTimeTrigger, 2);
            Image.color = new Color(1, 1, 1, 1 - (float)(0.85*FadeTimeTrigger));
            Debug.Log(Image.color.a);
            
        }
        if (Image.color.a < 0) Debug.Log("11111111111111111111111---"+Time.deltaTime);
    }
   public void SetFa()
    {
        fa = true;
    } 
}
