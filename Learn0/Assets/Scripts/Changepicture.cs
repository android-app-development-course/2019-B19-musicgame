using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Changepicture : MonoBehaviour {

	public GameObject obj;
	// Use this for initialization
	void Start () {
		int num;
		num=PlayerPrefs.GetInt ("scenenum");
		SpriteRenderer sr = obj.transform.GetComponent<SpriteRenderer>();

		if (num == 0) {
			Sprite sprite1 = Resources.Load ("Sprites/1", typeof(Sprite)) as Sprite;
			sr.sprite = sprite1;
		}
		if (num == 1) {
			Sprite sprite2 = Resources.Load ("Sprites/2", typeof(Sprite)) as Sprite;
			sr.sprite = sprite2;
		}
		if (num == 2) {
			Sprite sprite3 = Resources.Load ("Sprites/3", typeof(Sprite)) as Sprite;
			sr.sprite = sprite3;
		}
		
	}
	void Update () {

	}

}
