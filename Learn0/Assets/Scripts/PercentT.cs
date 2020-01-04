using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using LitJson;
public class PercentT : MonoBehaviour {

	public static Text txt;
	int num;
	string path;
	void Start()
	{
		txt= GameObject.Find ("PercentT").GetComponent<Text>();
		string percent;
		percent = PlayerPrefs.GetString ("done");
		txt.text = percent;

	}
}