using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankShow : MonoBehaviour {

    float time;
    string[] rank = { "rank1", "rank2", "rank3" };
    float[] ra_a = { 1, 1, 1 };
    float[] ra_x = { 1, 0.0126f * player.line_y, 0.0126f * player.line_y };
    float[] ra_y = { 1, 0.009f * player.line_y, 0.009f * player.line_y };
    // Use this for initialization
    void Start () {
        transform.localScale = new Vector2(0.00504f*1.5f * player.line_y, 0.0036f *1.5f* player.line_y);
    }
	
	// Update is called once per frame
	void Update () {
        //每0.0005f执行一次
        if (time >= 0.0005f)
        {
            if (transform.Find("rank1").GetComponent<Image>().color.a > 0)
            {
                //Debug.Log(ra_a[0]);
                Rank_ch(rank[0], ref ra_a[0], ref ra_x[0], ref ra_y[0]);
                //transform.Find("rank1").GetComponent<Image>().color = new Color(1, 1, 1, (1 - (float)(0.12 * time)));
                //transform.Find("rank1").transform.localScale = new Vector3((0.5f + (float)(0.2 * time)), (0.8f + (float)(0.2 * time)), (0.8f + (float)(0.2 * time)));
            }
            if ((transform.Find("rank1").GetComponent<Image>().color.a < 0.55) && (transform.Find("rank2").GetComponent<Image>().color.a > 0))
            {
                Rank_ch(rank[1], ref ra_a[1], ref ra_x[1], ref ra_y[1]);
                //transform.Find("rank2").GetComponent<Image>().color = new Color(1, 1, 1, (1 - (float)(0.9 * (time))));
                //transform.Find("rank2").transform.localScale = new Vector3((0.5f + (float)(0.2 * time)), (0.8f + (float)(0.2 * time)), (0.8f + (float)(0.2 * time)));
            }

            if ((transform.Find("rank2").GetComponent<Image>().color.a < 0.55) && (transform.Find("rank3").GetComponent<Image>().color.a > 0))
            {
                Rank_ch(rank[2], ref ra_a[2], ref ra_x[2], ref ra_y[2]);
                //transform.Find("rank3").GetComponent<Image>().color = new Color(1, 1, 1, (1 - (float)(0.6 * (time))));
                //transform.Find("rank3").transform.localScale = new Vector3((0.5f + (float)(0.2 * time)), (0.8f + (float)(0.2 * time)), (0.8f + (float)(0.2 * time)));
            }
            if ((transform.Find("rank3").GetComponent<Image>().color.a < 0))
                Destroy(gameObject);

            time = 0;
        }
        time += Time.deltaTime;
        
    }
    void OnEnable()
    {
        
    }
    
   void Rank_ch(string Rank,ref float ra_a, ref float ra_x, ref float ra_y)
    {
        //Debug.Log(transform.Find(Rank).GetComponent<Image>().color.a);

        transform.Find(Rank).GetComponent<Image>().color = new Color(1, 1, 1, (ra_a-=0.055f));
        transform.Find(Rank).transform.localScale = new Vector2((ra_x += 0.0476f*2), (ra_y += 0.07f*2));//, (0.8f + (float)(0.2 * time)));
        transform.Find(Rank).transform.Rotate(new Vector3(0,0,-2.5f));
    }
}
