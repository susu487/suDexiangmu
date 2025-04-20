using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor.Compilation;
using UnityEngine;

public class project 
{
    private project() { }
    //单例模式：两个静态
    private static project instance=new project();
    //静态只读属性
    public static project Instance
    {
        get
        {
            return instance;
        }
    }
    public void SaveDate(object date,string KeyName)
    {
        string savekeyname;
        //先获得对象类型
        Type dateType = date.GetType();
        //获得全部字段
        FieldInfo[] fields=dateType.GetFields();
        //遍历全部字段
        foreach(FieldInfo field in fields)
        {
            //获取各个字段名和值
            string fieldname = field.Name;
            object fieldvalue = field.GetValue(date);
            savekeyname = KeyName + fieldname;
            //存入
            //PlayerPrefs.SetString(savekeyname,fieldvalue.ToString());
            SaveValue(fieldvalue, savekeyname);
        }

    }
    public void SaveValue(object fieldvalue,string keyname)
    {
        if (fieldvalue.GetType() == typeof(int))
        {
            PlayerPrefs.SetInt(keyname, (int)fieldvalue);
        }
        if (fieldvalue.GetType() == typeof(float))
        {
            PlayerPrefs.SetFloat(keyname, (float)fieldvalue);
        }
        if (fieldvalue.GetType() == typeof(string))
        {
            PlayerPrefs.SetString(keyname, fieldvalue.ToString());
        }
        if (fieldvalue.GetType() == typeof(bool))
        {
            PlayerPrefs.SetInt(keyname, (bool)fieldvalue ? 1 : 0);
        }
        //IsAssignableFrom：判断一个类型是否可以被赋值给另一个类型
        //类可以赋值给父类，如果TRUE说明fieldvalue是一个list类
        if (typeof(IList).IsAssignableFrom(fieldvalue.GetType()))
        {
            //将list类转成Ilist类
            IList list =fieldvalue as IList;
            //先存储列表的长度
            PlayerPrefs.SetInt(keyname, list.Count);
            //遍历列表
            int index = 1;
            foreach(object item in list)
            {
                //判断每个数据的类型，并存入
                //列表的每个数据都要加上index防止重复
                SaveValue(item, keyname+index);
                index++;
            }
        }
        //如果是字典类，相同思路，父类装子类
        if (typeof(IDictionary).IsAssignableFrom(fieldvalue.GetType()))
        {
            Debug.Log("dictionary" + keyname);
            IDictionary dic=fieldvalue as IDictionary;
            PlayerPrefs.SetInt(keyname, dic.Count);
            //遍历字典
            int index = 1;
            foreach(object key in dic.Keys)
            {
                //将每对键值存入
                SaveValue(key, keyname + "key_" + index);
                SaveValue(dic[key], keyname + "value_" + index);
                index++;
            }
        }
        //自定义类
        else
        {
            SaveDate(fieldvalue, keyname);
        }
    }
    public object LoadDate(Type type,string KeyName)
    {
        //根据传入的type创造一个对象
        object date=Activator.CreateInstance(type);
        //向该对象里面传数据
        //先得到所有字段
        FieldInfo[] infos=type.GetFields();
        string loadkeyname = "";
        foreach(FieldInfo info in infos)
        {
            //loadkeyname必须和存储时一样
            loadkeyname=KeyName+"_"+ info.Name;
            //通过key读取数据
            info.SetValue(date, info.GetValue(date));
        }
        return date;
    }
    public object LoadValue(Type fieldtype, string KeyName)
    {
        //根据字段类型判断用哪个API读取数据
        if (fieldtype == typeof(int))
        {
            return PlayerPrefs.GetInt(KeyName,0);
        }
        if (fieldtype == typeof(float))
        {
            return PlayerPrefs.GetFloat(KeyName, 0);
        }
        if (fieldtype == typeof(string))
        {
           return PlayerPrefs.GetString(KeyName, "");
        }
        if (fieldtype == typeof(bool))
        {
            return PlayerPrefs.GetInt(KeyName, 0)==1?true:false;
        }
        return null;
    }
}
