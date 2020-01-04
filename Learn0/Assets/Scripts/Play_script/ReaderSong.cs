/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using LitJson;




public class ScoreitemItem
{
    /// <summary>
    /// 
    /// </summary>
    public int type { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string x { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string time { get; set; }
}

public class Root
{
    /// <summary>
    /// 
    /// </summary>
    public List<ScoreitemItem> scoreitem { get; set; }
}

public class ReaderSong : MonoBehaviour
{
    public static List<Note> note = new List<Note>();
    public static  Note newone;
    StreamReader sr;
    JsonReader js;
    Root r;
    // Use this for initialization
    void Start(){
       
    }
    void Awake()
    {
        //读取歌曲信息
        sr = new StreamReader(Application.dataPath + "/Resources/SongData/SongData1.json");
        js = new JsonReader(sr);
        r = JsonMapper.ToObject<Root>(sr);
        Text text = GameObject.Find("Canvas/Te").GetComponent<Text>();
        text.text = note.Count.ToString(); text.text = r.scoreitem[0].x;
        for (int i = 0; i < r.scoreitem.Count; i++)
        {
            newone = new Note();
            newone.x = float.Parse(r.scoreitem[i].x);
            newone.time = float.Parse(r.scoreitem[i].time);
            newone.type = r.scoreitem[i].type;
            //Debug.Log("new" + i + ":" + newone.x + "  " + newone.type + "  " + newone.time);
            note.Add(newone);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
        //for (int i = 0; i < note.Count; i++)
        //    Debug.Log(i + ":" + note[i].x + " " + note[i].time + " " + note[i].type + " ");
    }
}
*/