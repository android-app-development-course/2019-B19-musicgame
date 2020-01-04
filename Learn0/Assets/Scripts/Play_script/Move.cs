using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
    // Use this for initialization
    Image image;
    float time;
    void Start() {
        //GetComponent<Rigidbody>().velocity = transform.forward * speed;
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed*player.line_y;
        this.transform.localScale = new Vector3((float)(0.0056*1.5*player.line_y), (float)(0.11*1.25 * player.line_y), (float)(0.006*1.25 * player.line_y));
    }

    // Update is called once per frame
    void Update() {
        //Debug.Log("y坐标为：" + this.transform.position.y+"line_y;"+player.line_y);
        //Physics.gravity = new Vector3(0, -80, 0);

        if (this.transform.position.y < (0.35f * player.line_y))
        {
            //Debug.Log("move__Destory");
            Touch_text touch_Text = new Touch_text();
            touch_Text.IsMiss();
            time += (Time.deltaTime - (int)(Time.deltaTime));
            transform.Find("picture").GetComponent<Image>().color = new Color(1, 1, 1, (1 - (float)(11 * time)));
            
            if (transform.Find("picture").GetComponent<Image>().color.a < 0) 
                Destroy(gameObject);
        }
        //if (this.transform.position.y < (6.5 * player.line_y))
        //{
        //    if (this.transform.position.y < (6.5 * player.line_y) && this.transform.position.y > (3.8 * player.line_y))
        //    {
        //        Debug.Log("key__miss----------------------------------------------------------------------------------------------------------------------");
        //    }
        //    else if (this.transform.position.y < (3.8 * player.line_y) && this.transform.position.y > (1.8 * player.line_y))
        //    {
        //        Debug.Log("key__good-----------------------------------------------------------------------------------------------------------------------");
        //    }
        //    else if (this.transform.position.y < (1.8 * player.line_y) && this.transform.position.y > (0.6 * player.line_y))
        //    {
        //        Debug.Log("key__great----------------------------------------------------------------------------------------------------------------------");
        //    }
        //    else
        //    {
        //        Debug.Log("key__bad");
        //    }
        //}
    }
    public void Setspped(float sp)
    {
        speed = sp;
    }
 }  

