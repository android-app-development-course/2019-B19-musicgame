using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using System.IO;
using LitJson;
using System.Xml;
public class PageView : MonoBehaviour, IBeginDragHandler, IEndDragHandler
{
    private ScrollRect rect;
    private float targethorizontal = 0;
    private List<float> posList = new List<float>();//存四张图片的位置(0, 0.333, 0.666, 1) 
    private bool isDrag = true;
    private float startTime = 0;
	public int curIndex = 0;
	private float startDragHorizontal;
    public float speed = 4;      //滑动速度  


  //toggle开关


    void Start()
    {
		PlayerPrefs.SetInt ("scenen",0);
        rect = GetComponent<ScrollRect>();
        float horizontalLength = rect.content.rect.width - GetComponent<RectTransform>().rect.width;
        var _rectWidth = GetComponent<RectTransform>().rect.width;
        for (int i = 0; i < rect.content.transform.childCount; i++)
        {
            posList.Add(_rectWidth * i / horizontalLength);
        }
        curIndex = 0;
		showrating ();

    }

    void Update()
    {
		if (!isDrag)
		{
			startTime += Time.deltaTime;
			float t = startTime * speed;
			rect.horizontalNormalizedPosition = Mathf.Lerp(rect.horizontalNormalizedPosition, targethorizontal, t);  //加速滑动效果
			//rect.horizontalNormalizedPosition = Mathf.Lerp(rect.horizontalNormalizedPosition, targethorizontal, Time.deltaTime * speed); //缓慢匀速滑动效果

		}

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        isDrag = true;
        //开始拖动
        startDragHorizontal = rect.horizontalNormalizedPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        float posX = rect.horizontalNormalizedPosition;
        int index = 0;
        float offset = Mathf.Abs(posList[index] - posX);  //计算当前位置与第一页的偏移量
        for (int i = 1; i < posList.Count; i++)
        {    //遍历页签，选取偏移量最小的那个页面
            float temp = Mathf.Abs(posList[i] - posX);
            if (temp < offset)
            {
                index = i;
                offset = temp;
            }
        }
        curIndex = index;
		if (curIndex == 0) {
			PlayerPrefs.SetInt ("scenen",0);
		}
		if (curIndex == 1) {
			PlayerPrefs.SetInt ("scenen",1);
		}
		if (curIndex == 2) {
			PlayerPrefs.SetInt ("scenen",2);
		}

	
        targethorizontal = posList[curIndex]; //设置当前坐标，更新函数进行插值  
        isDrag = false;
        startTime = 0;
		showrating ();
     
    }



	public void showrating()
	{
		string rating = "";
		string score = "";
		string percent="";
		XmlDocument xx = new XmlDocument ();
		XmlNodeList sts;
		switch (curIndex) {
		case 0:
			xx.Load (Application.streamingAssetsPath+ "/a.xml");
			sts = xx.SelectSingleNode ("sta").ChildNodes;		
			foreach (XmlElement el in sts) {
				if (el.Name == "score") {
					score = el.InnerText.ToString ();
				}
				if (el.Name == "rating") {
					rating = el.InnerText.ToString ();
				}
				if (el.Name == "percent") {
					percent = el.InnerText.ToString ();
				}
			}
			readscore.txt2.text = score;
			readrating.txt.text = rating;
			Readpercent.txt1.text = percent;
			break;
		case 1:			
			xx.Load (Application.streamingAssetsPath + "/b.xml");
			sts = xx.SelectSingleNode ("sta").ChildNodes;		
			foreach (XmlElement el in sts) {
				if (el.Name == "score") {
					score = el.InnerText.ToString ();
				}
				if (el.Name == "rating") {
					rating = el.InnerText.ToString ();
				}
				if (el.Name == "percent") {
					percent = el.InnerText.ToString ();
				}
			}
			readrating.txt.text = rating;
			Readpercent.txt1.text = percent;
			readscore.txt2.text = score;
			break;
		case 2:			
			xx.Load (Application.streamingAssetsPath+ "/c.xml");
			sts = xx.SelectSingleNode ("sta").ChildNodes;		
			foreach (XmlElement el in sts) {
				if (el.Name == "score") {
					score = el.InnerText.ToString ();
				}
				if (el.Name == "rating") {
					rating = el.InnerText.ToString ();
				}
				if (el.Name == "percent") {
					percent = el.InnerText.ToString ();
				}
			}
			readrating.txt.text = rating;
			Readpercent.txt1.text = percent;
			readscore.txt2.text = score;
			break;
		default:
			break;
		}
	}





}
