using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_text : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0)) { 
            
            //Debug.Log(mousePos);
            if (this.transform.position.y < (1.15 * player.line_y)) {
                Vector2 mousePos = new Vector2((Input.mousePosition.x-(float)(player.line_y)), Input.mousePosition.y);
             
                //Debug.Log("--------------------"+this.transform.position.x+"--------------------");
                if (Math.Abs(this.transform.position.x - mousePos.x) < (float)( 2.8*player.line_y))
                {
                 
                    Destroy(gameObject);
                    player player = new player();
                    player.Ch_point(3,this.transform.position);
                    Touch_text touch_ = new Touch_text();
                    touch_.Ch_Combo();
                }
            }
        }
    }
}
