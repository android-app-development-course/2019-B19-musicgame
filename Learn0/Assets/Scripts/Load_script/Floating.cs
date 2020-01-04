using UnityEngine;
using System.Collections;// 主界面的开始按钮使用该脚本，控制上下来回浮动
public class Floating : MonoBehaviour
{
    private float speed = -10;
    private Vector3 StartPosition;
    private Vector3 NowPosition;
    System.Random r1 = new System.Random();
    static float v = -2f;
    float []a =new float[] { 1, -1 }; 
    int i = 0;
    void Start()
    {
        StartPosition = this.transform.position;
    }
    
    /*void FixedUpdate()
    {
        StartPosition = this.transform.position;
        transform.RotateAround(StartPosition, new Vector3(0f, 0f, 1f), a[i++]*speed);
        //i = i++;
        if (i == 2)
        {
            i = 0;
        }

        Debug.Log("--+"+a[i]);
        Debug.Log(i);
    }
*/


	private void Update()
	{

		if (Time.frameCount % 5 == 0)
		{
			StartPosition = this.transform.position;
			transform.RotateAround(StartPosition, new Vector3(0f, 0f, 1f),  a[i++]*speed);
			//i = i++;
			if (i == 2)
			{
				i = 0;
			}

		}



}
}
