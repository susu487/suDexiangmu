using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class start : MonoBehaviour
{
    private static start instance;
    public static void showme()
    {
        if (instance != null)
        {
            // 物体不失活
            instance.gameObject.SetActive(true);
        }
    }
    public void hideme()
    {
        if (instance != null)
        {
            // 物体失活
            instance.gameObject.SetActive(false);
        }
    }

    public GUIStyle style;
    public Texture tex;
    public Rect rect;
    public Rect rect1;
    public Rect rect2;
    public Rect rect3;
    public GUIContent content;
    public GUIStyle buttonstyle;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        // 确保物体是激活状态
        gameObject.SetActive(true);
    }

    public void OnGUI()
    {
        // 标题
        GUI.Label(rect, "苏菲大女王", style);
        // 开始，退出，设置
        if (GUI.Button(rect1, "开始游戏", buttonstyle))
        {
            hideme();
            login.showme();
        }
        if (GUI.Button(rect2, "退出游戏", buttonstyle))
        {
            Application.Quit();  // 退出游戏
        }
        if (GUI.Button(rect3, "设置游戏", buttonstyle))
        {
            shezhi.showme();
            Debug.Log("显示设置界面");
            hideme();
            Debug.Log("隐藏开始界面");
        }
    }
}
