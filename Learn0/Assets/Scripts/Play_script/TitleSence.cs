using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[AddComponentMenu("Code/TitleSence")]
public class TitleSence : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void onbutton()
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1;
    }
}
