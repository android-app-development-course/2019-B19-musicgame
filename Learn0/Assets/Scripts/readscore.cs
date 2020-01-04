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
	public int score { get; set; }
	/// <summary>
	/// 
	/// </summary>
	public string rating { get; set; }
	/// <summary>
	/// 
	/// </summary>
	public string percent { get; set; }
}

public class Root
{
	/// <summary>
	/// 
	/// </summary>
	public List <ScoreitemItem > scoreitem { get; set; }
}
public class readscore : MonoBehaviour {
	public static Text txt2;
	void Start()
	{
		txt2 = GameObject.Find ("scoreText").GetComponent<Text>();
	}

}
