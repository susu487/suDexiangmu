using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a3 : MonoBehaviour
{
    private Boolean issel1;
    private Boolean issel2;
    public Rect rect1;
    public Rect rect2;
    public Rect rect3;
    private void OnGUI()
    {
        issel1 = GUI.Toggle(rect1, issel1, "音乐开关");
        issel2 = GUI.Toggle(rect2, issel2, "音效开关");
        if (GUI.Button(rect3, "关闭"))
        {

        }
    }
}
