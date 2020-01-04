using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class Score : MonoBehaviour{

	public int score;
	public string rating;
	public string percent;

	public Score(int _score,string _rating,string _percent)
	{
		score = _score;
		rating = _rating;
		percent = _percent;
	}
}