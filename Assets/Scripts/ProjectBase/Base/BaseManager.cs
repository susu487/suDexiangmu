using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//1.C#中 泛型的知识
//2.设计模式中 单例模式的知识

/// <summary>
/// 总结使用（不包含mono）：创建各个管理器脚本，继承这个，然后把脚本拖到场景中对应的管理器对象上就行了
/// </summary>
/// <typeparam name="T"></typeparam>
public class BaseManager<T> where T:new()
{
    private static T instance;

    public static T GetInstance()
    {
        if (instance == null)
            instance = new T();
        return instance;
    }
}

