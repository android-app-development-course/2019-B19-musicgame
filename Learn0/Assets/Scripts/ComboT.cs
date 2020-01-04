using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using LitJson;

public class ComboT : MonoBehaviour {

	public static Text txt;

	void Start()
	{
		txt= GameObject.Find ("ComboT").GetComponent<Text>();
		int combo;
		combo = PlayerPrefs.GetInt ("combo");
		txt.text = combo.ToString();

	}

}