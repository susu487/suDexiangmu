using System;
using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
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
        hideme();
    }
    private void OnGUI()
    {
        Boolean a=GUI.Button(btrect, "登录");
        
        GUI.Label(nameRect, "请输入用户名",style1);
        GUI.Label(passwordRect, "请输入密码",style2);
        name=GUI.TextField(inputname, name);
        password=GUI.TextField(intputpassword, password);
        if (name.Equals(admin))
        {
            if (password.Equals(adminpassword))
            {
                if (a)
                {
                    SceneManager.LoadScene("GameScene");
                }
                
            }
        }
        if( GUI.Button(rRect, "返回上一级"))
        {
            hideme();
            start.showme();
        }

    }
}
