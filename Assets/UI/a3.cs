using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a3 : MonoBehaviour
{
    private static a3 instance;
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
            a1.showme();
        }
    }
}
