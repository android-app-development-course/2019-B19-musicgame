using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour {

    Slider slider;

    void Start()
    {
        slider = GameObject.Find("Canvas/Slider").GetComponent<Slider>();
    }
    public void PlayGame()
    {
        //slider = GameObject.Find("Canvas/Slider").GetComponent<Slider>();
        while (slider.value < 1)
        {
            Debug.Log("-->" + slider.value);
            slider.value  += 0.1f;
            //System.Threading.Thread.Sleep(2000);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

       
    }
}
