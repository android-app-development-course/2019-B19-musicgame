using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Touch_text : MonoBehaviour {
    public static int Com;
    private GameObject[] targetArr;
    player player = new player();
    public GameObject my_prefab;
    //private List<float> KnifeList;
    private Text Text_Combo;
    //enum Rank{bad,good,great }
    float time;
	public int MaxCom;//最大连击

   
    // Use this for initialization
    void Start () {
		Com = 0;
		MaxCom = 0;
    }
	
	// Update is called once per frame
	void Update () {    
        //KnifeList = new List<float>();
        targetArr = GameObject.FindGameObjectsWithTag("Key");//寻找带标签的对象，做成集合
        if (Input.GetMouseButtonDown(0)){
            if (Input.mousePosition.y <= (float)(1.5 * player.line_y) && Input.mousePosition.y >= (float)(0.3 * player.line_y))
            {
                Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);//让鼠标的屏幕坐标与对象坐标一致   
                //Debug.Log("mouse:" + mousePos.x+","+mousePos.y);
                Getpoint(mousePos);
               
            }    
        }
	}
    public void Getpoint(Vector3 mousePos) {
        float Distance=100*player.line_y;
        int target = -1;
        for (int i = 0; i < targetArr.Length; i++)
        {
            if (Math.Abs(targetArr[i].transform.position.x -mousePos.x)< 1.6f * player.line_y)
            {
                //找出离触摸点最近的一个key
                if(Math.Abs(targetArr[i].transform.position.y - mousePos.y) < Distance) {
                    Distance = Math.Abs(targetArr[i].transform.position.y-mousePos.y);
                    target = i;
                }
            }
        }
        if (target != -1){
            float pos_y = targetArr[target].transform.position.y;
            if (pos_y < (6.5*player.line_y)){
                if (pos_y < (6.5 * player.line_y) && pos_y > (3.9 * player.line_y))
                {
                    player.Ch_point(1, targetArr[target].transform.position);
                }
                else if (pos_y < (3.9 * player.line_y) && pos_y > (1.8 * player.line_y))
                {
                    player.Ch_point(2, targetArr[target].transform.position);
                }
                else
                {
                    player.Ch_point(3, targetArr[target].transform.position);
                }
                //Debug.Log("Touch_Destory");
                //Debug.Log(target+"  "+targetArr[target].transform.position.x);
                Destroy(targetArr[target]);
                Ch_Combo();
                //Debug.Log(Com);
            }
        }
    }
    public void Ch_Combo()
    {
        Com++;
		if (Com > MaxCom) {
			MaxCom = Com;
			BGM.combo = MaxCom;
		}
        Text_Combo = GameObject.Find("Canvas/Double Hit").GetComponent<Text>();
        Text_Combo.text = Com.ToString();
    } 
    public void IsMiss()
    {
        if (Com != 0) { 
            Com = 0;
            Text_Combo = GameObject.Find("Canvas/Double Hit").GetComponent<Text>();
            Text_Combo.text = Com.ToString();
        }
        //Debug.Log(Com);
    }

   
    
}
