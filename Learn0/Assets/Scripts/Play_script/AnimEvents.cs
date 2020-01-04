using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEvents : MonoBehaviour {

	public BGM bgm=new BGM();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //控制倒数动画完后在开始游戏
    void GameGoon()
	{
		AudioSource audioSource = gameObject.GetComponent<AudioSource> ();
		Time.timeScale = 1;
		bgm.BGMplay ();

    }
    //使暂停面板位于ui层级最下，不被其他ui遮盖
    void Uiup()
    {
        this.transform.SetAsLastSibling();

    }
}
