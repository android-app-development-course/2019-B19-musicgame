using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class readrating : MonoBehaviour {

	public static Text txt;
	void Start()
	{
		txt = GameObject.Find ("ratingText").GetComponent<Text>();
	}
}
