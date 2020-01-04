using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnProgress : MonoBehaviour
{

    public void OnBtnClick()
    {
        Globe.nextSceneName = "Scene0";//目标场景名称
        SceneManager.LoadScene("Loading");//加载进度条场景
    }
}