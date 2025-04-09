using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shezhi : MonoBehaviour
{
    private static shezhi instance;
    public static void showme()
    {
        if (instance != null)
        {
            //物体不失活
            instance.gameObject.SetActive(true);
        }
    }
    public static void hideme()
    {
        if (instance != null)
        {
            //物体失活
            instance.gameObject.SetActive(false);
        }
    }
    private Boolean issel1;
    private Boolean issel2;
    public Rect rect1;
    public Rect rect2;
    public Rect rect3;
    public Rect volumeRect;
    public float nowvalue = 0;
    public Rect rRect;
    
    
    private void Awake()
    {
        instance = this;
        hideme();
    }
    private void OnGUI()
    {
        issel1 = GUI.Toggle(rect1, issel1, "音乐开关");
        issel2 = GUI.Toggle(rect2, issel2, "音效开关");
        if (GUI.Button(rect3, "关闭"))
        {
            hideme();
            start.showme();
        }
        nowvalue = GUI.HorizontalSlider(volumeRect, nowvalue, 0, 100);
        if (GUI.Button(rRect, "返回上一级"))
        {
            hideme();
            start.showme();
        }
    }
}

//第一种写法-------------------------------------------------------------------

//class danli
//{
//    private static danli instance;
//    public static danli Instance
//    {
//        get
//        {
//            if (instance == null)
//            {
//                instance = new danli();
//            }
//            return instance;
//        }
//    }

//    public void 要干的事()
//    {
//        //以后就这么用：
//        danli.Instance.要干的事111();
//    }
//    public void 要干的事111()
//    {
//        //blablablabla
//    }
//}

//第二种写法------------------------------------------------------------------------
//class danli
//{
//    // 在类加载时立即创建实例
//    private static readonly danli instance = new danli();

//    // 构造函数私有化，防止外部创建实例
//    private danli() { }

//    // 提供一个公共的静态方法来获取唯一实例
//    public static danli Instance
//    {
//        get
//        {
//            return instance;
//        }
//    }

//    public void 要干的事()
//    {
//        // 以后就这么用：
//        danli.Instance.要干的事111();
//    }

//    public void 要干的事111()
//    {
//        // blablablabla
//    }
//}
