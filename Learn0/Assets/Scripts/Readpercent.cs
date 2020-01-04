using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using LitJson;

public class Readpercent : MonoBehaviour {
	public static Text txt1;
	void Start()
	{
		txt1= GameObject.Find ("percentText").GetComponent<Text>();
	}

}
