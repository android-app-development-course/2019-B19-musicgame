using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using LitJson;

public class ScoreT : MonoBehaviour {

	public static Text txt;
	int num;
	string path;
	void Start()
	{
		txt= GameObject.Find ("ScoreT").GetComponent<Text>();
		int score;
		score = PlayerPrefs.GetInt ("score");
		txt.text = score.ToString();

	}

}