using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop_bg : MonoBehaviour
{
    public Animator Ani_set;
    public Animator anim;
	public BGM bgm=new BGM();
    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void show_stbg()
    {
		bgm.BGMstop ();
        Ani_set.SetBool("Isno", true);
        Ani_set.SetBool("Isstop", true);
        Time.timeScale = 0;
    }//设置播放动画的参数与游戏暂停
    public void hide_stbg()
    {
        Ani_set.SetBool("Isno", false);
        Ani_set.SetBool("Isstop", false);
       
    }
    
    
}
