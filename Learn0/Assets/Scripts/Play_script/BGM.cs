using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using LitJson;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Xml;



public class BGM : MonoBehaviour {
	
	bool flag=true;
	int k; //获取场景号
	string path;
	int p;
	int scoret;
	string ratingt;
	string percentt;
	public static int point;
	public static int combo;
	public static string done;
	public static string rate;

	public AudioClip[] adios;


    // Use this for initialization
	void Start () {
		k=PlayerPrefs.GetInt ("scenen");
		this.GetComponent<AudioSource> ().clip = adios [k];
		this.GetComponent<AudioSource> ().Play ();


    }
	
	// Update is called once per frame
	void Update () {

		if (!this.GetComponent<AudioSource>().isPlaying&&flag) {
			
			PlayerPrefs.SetInt ("score",point);
			PlayerPrefs.SetString ("done", done);
			PlayerPrefs.SetInt ("combo", combo);
			PlayerPrefs.SetString ("rate", rate);
			PlayerPrefs.SetInt ("scenenum",k);
			write (k);
			SceneManager.LoadScene (5);
		}

	}
	public  void BGMstop(){
		flag = false;
		this.GetComponent<AudioSource>().Pause ();

	}

	public  void BGMplay(){
		flag = true;
		this.GetComponent<AudioSource>().Play ();
	}

	void write(int k){
		if (k == 0) {
			path = "/a.xml";
		}
		if (k == 1) {
			path = "/b.xml";
		}
		if (k == 2) {
			path = "/c.xml";
		}


		//从文件读取最高分数比较，若高于最高分数则覆盖，否则，不写入
		string kk="";
		XmlDocument xx = new XmlDocument ();
		xx.Load (Application.streamingAssetsPath + path);
		XmlNodeList s = xx.SelectSingleNode ("sta").ChildNodes;
		foreach (XmlElement x in s) {
			if (x.Name == "score") {
				kk = x.InnerText.ToString ();
			}
		}
		p = int.Parse (kk);
		Debug.Log (p);

		if (point > p) {
			Debug.Log ("要创建文件"+point);



			foreach (XmlElement x in s) {
				if (x.Name == "score") {
					x.InnerText = point.ToString ();
				}
				if (x.Name == "rating") {
					x.InnerText = rate.ToString ();
				}
				if (x.Name == "percent") {
					x.InnerText = done.ToString ();
				}
			}
			xx.Save (Application.streamingAssetsPath + path);

			}
		}
			
			




		
		
}




