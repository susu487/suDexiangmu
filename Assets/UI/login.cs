using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class login : MonoBehaviour
{
    private static login instance;
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

    public Rect nameRect;
    public Rect inputname;
    public Rect passwordRect;
    public Rect intputpassword;
    public string name;
    public string password;
    public string admin = "admin";
    public string adminpassword = "888888";
    public GUIStyle style1;
    public GUIStyle style2;
    public Rect btrect;
    public Rect rRect;

    private void Awake()
    {
        instance = this;
        hideme();  // 隐藏登录界面，避免显示在初始时
    }

    private void OnGUI()
    {
        // 登录按钮
        Boolean a = GUI.Button(btrect, "登录");

        // 显示输入框和标签
        GUI.Label(nameRect, "请输入用户名", style1);
        GUI.Label(passwordRect, "请输入密码", style2);
        name = GUI.TextField(inputname, name);
        password = GUI.PasswordField(intputpassword, password, '*'); // 使用星号显示密码

        if (a && name.Equals(admin) && password.Equals(adminpassword))
        {
            // 登录成功，加载场景
            SceneManager.LoadScene("GameScene");
        }

        // 返回按钮
        if (GUI.Button(rRect, "返回上一级"))
        {
            hideme();
            start.showme();
        }
    }
}
