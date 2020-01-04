using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class key_show : MonoBehaviour {

    // Use this for initialization
    public GameObject my_prefab;
    public GameObject my_Canvas ;
    private int Pos_x = 150;

    int count = 1;
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Make_p(int y)
    {
        //my_prefab = (GameObject)Resources.Load("Prefab/key1");
        my_prefab = (GameObject)Resources.Load("Prefab/2_key");
        my_prefab = Instantiate(my_prefab);  //Prefab实体化
        my_Canvas = GameObject.Find("Canvas");
        my_prefab.transform.parent = my_Canvas.transform;
        //my_prefab.transform.position = new Vector3(-210, -210, 0);
        Vector3 pos = transform.position;
        pos.x = Pos_x;
        Pos_x += 30;
        pos.y = y;
        //pos.y = 400;
        my_prefab.transform.position = pos;
        //move();
        //Debug.Log("--------------------------------NO" + count + "_X:" + Pos_x+"---------------------------------");
        count++;
        Debug.Log(count);
    }
    public void mak_Pre()
    {
        Make_p(350);
        //Make_p(20,true);
        
    }
    //public void move()
    //{
    //    transform.Translate(Vector3.forward * 5 * Time.deltaTime, Space.World);
    //}

    public void cheak()
    {
        Debug.Log(count + ":great!!!!");
    }
}
