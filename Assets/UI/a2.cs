using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a2 : MonoBehaviour
{
   
    public int nowselindex = 1;
    public Rect rect1 ;
    public Rect rect2 ;
    public Rect rect3;
    // Start is called before the first frame update
    private void OnGUI()
    {

        if (GUI.Toggle(rect1, nowselindex == 1, "选项A"))
        {
            nowselindex = 1;
        }
        if (GUI.Toggle(rect2, nowselindex == 2, "选项B"))
        {
            nowselindex = 2;
        }
        if (GUI.Toggle(rect3, nowselindex == 3, "选项C"))
        {
            nowselindex = 3;
           
        }
    }
}
