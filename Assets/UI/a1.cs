using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class a1 : MonoBehaviour
{
    public Texture tex;
    public Rect rect;
    public Rect rect1;
    public Rect rect2;
    public Rect rect3;
    public GUIContent content;
    public GUIStyle buttonstyle;
    //public string text;
    // Start is called before the first frame update
    public void OnGUI()
    {
        //标题
        //GUI.Label(rect,"苏菲大女王", style);
        //开始，结束，设置
        if (GUI.Button(rect1, "开始游戏", buttonstyle))
        {
            SceneManager.LoadScene("GameScene");
        }
        GUI.Button(rect2, "退出游戏", buttonstyle);
        GUI.Button(rect3, "设置游戏", buttonstyle);
        
    }
}
