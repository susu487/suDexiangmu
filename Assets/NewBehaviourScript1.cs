using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public Rect rect1 = new Rect(10, 10, 100, 100);
    public Rect rect2 = new Rect(10, 60, 100, 100);
    public Rect rect3 = new Rect(10, 120, 100, 100);
    public bool duibu = true;
    public GUIStyle GUIStyle;
    public GUIContent a;

    public int nowselindex = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
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
