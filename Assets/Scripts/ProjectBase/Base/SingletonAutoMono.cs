using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//C#中 泛型知识点
//设计模式 单例模式的知识点
//继承这种自动创建的 单例模式基类 不需要我们手动去拖 或者 api去加了
//想用他 直接 GetInstance就行了
/// <summary>
/// 总结使用（包含mono，不用创建对象/挂载，所以无法编辑器调参数）：创建各个管理器脚本，继承这个，随后什么都不用管，不用挂载，不用创建对象
/// </summary>
/// <typeparam name="T"></typeparam>
public class SingletonAutoMono<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T GetInstance()
    {
        if (instance == null)
        {
            GameObject parent = GameObject.Find("Manager");
            if (parent == null)
            {
                parent = new GameObject("Manager");
                DontDestroyOnLoad(parent); // 把 Manager 整个标记为不销毁
            }

            GameObject obj = new GameObject(typeof(T).ToString());
            obj.transform.SetParent(parent.transform);
            instance = obj.AddComponent<T>();
        }
        return instance;
    }

}
