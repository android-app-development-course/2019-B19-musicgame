using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {
    float timeSpend;
    Image Line;
    public static float line_x,line_y;
    //用于保证在误差时间内只会生成1个key
    List<bool> doit;
    public GameObject my_prefab;
    public static GameObject my_Canvas;
    private Text Text_Point;
    private static double  key_point;
	public double point=0; //分数
    List<Note> note;
    int i,finish_key;
    // Use this for initialization
    void Start () {
        timeSpend = 0.0f;
		finish_key = 0;

        //提前实例一次需要使用的Perfab，保证游戏运行流畅
        //提前实例一次1_key
        my_prefab = (GameObject)Resources.Load("Prefab/1_key");
        my_prefab = Instantiate(my_prefab);  //Prefab实体化
        my_Canvas = GameObject.Find("Canvas");
        my_prefab.transform.parent = my_Canvas.transform;
        Vector3 pos = transform.position; pos.x = 0.1f * line_x;
        pos.y = (float)0.4 * line_y;
        pos.z = 0;
        my_prefab.transform.position = pos;
        my_prefab.transform.SetAsFirstSibling();
        //提前实例一次2_key
        my_prefab = (GameObject)Resources.Load("Prefab/2_key");
        my_prefab = Instantiate(my_prefab);  //Prefab实体化
        my_Canvas = GameObject.Find("Canvas");
        my_prefab.transform.parent = my_Canvas.transform;
        pos = transform.position; pos.x = 0.1f * line_x;
        pos.y = (float)0.4 * line_y;
        pos.z = 0;
        my_prefab.transform.position = pos;
        my_prefab.transform.SetAsFirstSibling();
        //提前实例一次rank_good
        my_prefab = (GameObject)Resources.Load("Prefab/Rank_good");
        my_prefab = Instantiate(my_prefab);  //Prefab实体化
        my_Canvas = GameObject.Find("Canvas");
        my_prefab.transform.parent = my_Canvas.transform;
        pos = transform.position; pos.x = 0.1f * line_x;
        pos.y = (float)0.4 * line_y;
        pos.z = 0;
        my_prefab.transform.position = pos;
        my_prefab.transform.SetAsFirstSibling();
        //提前实例一次rank_great
        my_prefab = (GameObject)Resources.Load("Prefab/Rank_great");
        my_prefab = Instantiate(my_prefab);  //Prefab实体化
        my_Canvas = GameObject.Find("Canvas");
        my_prefab.transform.parent = my_Canvas.transform;
        pos = transform.position; pos.x = 0.1f * line_x;
        pos.y = (float)0.4 * line_y;
        pos.z = 0;
        my_prefab.transform.position = pos;
        my_prefab.transform.SetAsFirstSibling();
    }
    void Awake()
    {
		int num=PlayerPrefs.GetInt("scenen");
		if (num == 0) { 
			note = SongData.note1;
		}
		if (num == 1) { 
			note = SongData.note2;
		}
		if (num == 2) { 
			note = SongData.note2;
		}
       
        i = 0;
        //Debug.Log(ReaderSong.note.Count);
        key_point = 1000000 / note.Count;//一个key比例得分
        doit = new List<bool>();
        //Debug.Log(key_point);
        for (int n = 0; n < note.Count; n++)
        {
            doit.Add(true);
        }
        Line = GameObject.Find("Canvas/Line").GetComponent<Image>();
        line_x = Line.transform.position.x;
        line_y = Line.transform.position.y;
    }

    //void Awake()
    //{

    //    i = 0;
    //    //Debug.Log(ReaderSong.note.Count);
    //    key_point = 1000000 / ReaderSong.note.Count;//一个key比例得分
    //    doit = new List<bool>();
    //    //Debug.Log(key_point);
    //    for (int n = 0; n < ReaderSong.note.Count; n++)
    //    {
    //        doit.Add(true);
    //    }
    //    Line = GameObject.Find("Canvas/Line").GetComponent<Image>();
    //    line_x = Line.transform.position.x;
    //    line_y = Line.transform.position.y;
    //    //note = SongData.note1;
    //}
    // Update is called once per frame

    //void Update()
    //{
    //    timeSpend += Time.deltaTime;

    //    //在0.05秒的误差内创建key

    //    //Debug.Log(i);
    //    if (i < note.Count)
    //    {
    //        //Debug.Log((Math.Abs(timeSpend - ReaderSong.note[i].time)));
    //        if ((Math.Abs(timeSpend - note[i].time) <= 2e-2) && doit[i])
    //        {
    //            doit[i] = false;
    //            Make_p(i); ;
    //            i++;
    //        }
    //    }
    //}
    void Update()
    {
        timeSpend += Time.deltaTime;
		//Debug.Log ("分数："+point);
        //在0.05秒的误差内创建key
        if (i < note.Count)
        {
            //Debug.Log((Math.Abs(timeSpend - note[i].time)));
            if ((Math.Abs(timeSpend - note[i].time) <= 25e-3) && doit[i])
            {
                doit[i] = false;
                Make_p(i); ;
                i++;
            }
        }
    }
    //public void Make_p(int i)
    //{
    //    //Debug.Log(i);
    //    //Debug.Log(note[i].x + " " + note[i].time + " ");
    //    if (ReaderSong.note[i].type == 1)
    //    {
    //        my_prefab = (GameObject)Resources.Load("Prefab/1_key");
    //    }
    //    else
    //    {
    //        my_prefab = (GameObject)Resources.Load("Prefab/2_key");
    //    }
    //    my_prefab = Instantiate(my_prefab);  //Prefab实体化
    //    my_Canvas = GameObject.Find("Canvas");
    //    my_prefab.transform.parent = my_Canvas.transform;
    //    Vector3 pos = transform.position;
    //    pos.x = (float)ReaderSong.note[i].x * line_x;
    //    pos.y = (float)12.5 * line_y;
    //    pos.z = 0;
    //    my_prefab.transform.position = pos;
    //}

    //创建下落块
    public void Make_p(int i)
    {
        //Debug.Log(i);
        //Debug.Log("------------------------------------"+note[i].x + " " + note[i].time + " ");
        if (note[i].type == 1)
        {
            my_prefab = (GameObject)Resources.Load("Prefab/1_key");
        }
        else
        {
            my_prefab = (GameObject)Resources.Load("Prefab/2_key");
        }
        my_prefab = Instantiate(my_prefab);  //Prefab实体化
        my_Canvas = GameObject.Find("Canvas");
        my_prefab.transform.parent = my_Canvas.transform;
        Vector3 pos = transform.position;
        pos.x = (float)note[i].x*line_x;
        pos.y = (float)12.5 *line_y;
        pos.z = 0;

        my_prefab.transform.position = pos;
    }

    //public  double KeyTotal()
    //{

    //    return (ti.Length);
    //}
    public void Ch_point(int i,Vector3 pos)
    {
        switch (i)
        {
            case 1:
                {
					Touch_text a = new Touch_text ();
					a.IsMiss ();
                    point += (key_point * 0.2);
                    break;
                }
            case 2:
                {
                    my_prefab = (GameObject)Resources.Load("Prefab/Rank_good");
                    my_prefab = Instantiate(my_prefab);
                    my_prefab.transform.parent = player.my_Canvas.transform;
                    pos.x += 0.2f * player.line_y;
                    my_prefab.transform.position = pos;
                    point += (key_point * 0.6);
					finish_key++;

                    break;
                }
            case 3:
                {

                    my_prefab = (GameObject)Resources.Load("Prefab/Rank_great");
                    my_prefab = Instantiate(my_prefab);
                    my_prefab.transform.parent = player.my_Canvas.transform;
                    pos.x += 0.2f * player.line_y;
                    my_prefab.transform.position = pos;
                    point += key_point;
					finish_key++;

                    break;
                }
        }

        //得分向上取整
        double poin = Math.Ceiling(point);
		BGM.point = (int)point;
		double percent = point / 1000000;
		string pt=(percent*100).ToString()+"%";
		BGM.done = pt;
		if (percent > 0.95) {
			BGM.rate = "S";
		}
		if(percent>0.9&&percent<=0.95){
			BGM.rate="A";
		}
		if (percent <= 0.9 && percent > 0.75) {
			BGM.rate="B";
		}
		if (percent <= 0.75) {
			BGM.rate="C";
		}
			
        //以防分数溢出
        if (poin > 1000000) {
            poin = 1000000;
        }
        
        //是得分显示7位数字
        string Point = poin.ToString();
        for (int I = 0; (7 - point.ToString().Length) > I; I++)
        {
            Point = "0" + Point;
        }
        Text_Point = GameObject.Find("Canvas/point").GetComponent<Text>();

        Text_Point.text = Point;
    }
}
