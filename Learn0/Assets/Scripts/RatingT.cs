using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using LitJson;

public class RatingT : MonoBehaviour {

	public static Text txt;
	int num;
	string path;
	void Start()
	{
		txt= GameObject.Find ("RatingT").GetComponent<Text>();
		string rating = "";
		rating = PlayerPrefs.GetString ("rate");
		txt.text = rating;
	
}
}
