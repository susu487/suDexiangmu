using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankInfo
{
    public string name;
    public int score;
    public int time;

    public RankInfo(string name, int score, int time)
    {
        this.name = name;
        this.score = score;
        this.time = time;
    }
}
public class RankListInfo
{
    public List<RankInfo> list;

    public void add(string name, int score, int time)
    {
        list.Add(new RankInfo(name, score, time));
    }
    public void save()
    {
        PlayerPrefs.SetInt("list.Count", list.Count);
        for (int i = 0; i < list.Count; i++)
        {

            PlayerPrefs.SetString("name" + i, list[i].name);
            PlayerPrefs.SetInt("score" + i, list[i].score);
            PlayerPrefs.SetInt("time" + i, list[i].time);
        }
    }
    public void load()
    {
        int num = PlayerPrefs.GetInt("list.Count", list.Count);
        list = new List<RankInfo>();
        for (int i = 0; i < num; i++)
        {
            string name = PlayerPrefs.GetString("name" + i);
            int score = PlayerPrefs.GetInt("score" + i);
            int time = PlayerPrefs.GetInt("time" + i);
            list.Add(new RankInfo(name, score, time));
        }

    }
    //class Player
    //{
    //    public List<item> itemlist;
    //    private string playerName;
    //    public void Save()//存储
    //    {
    //        PlayerPrefs.SetInt(playerName + "itemCount", itemlist.Count);
    //        for (int i = 0; i < itemlist.Count; i++)
    //        {
    //            PlayerPrefs.SetInt(playerName + "id" + i, itemlist[i].id);
    //            PlayerPrefs.SetInt(playerName + "count" + i, itemlist[i].count);
    //        }
    //        PlayerPrefs.Save();
    //    }
    //    public void Load(string playerName)//读取
    //    {
    //        this.playerName = playerName;
    //        //item数量
    //        int num = PlayerPrefs.GetInt(playerName+"itemCount", 0);
    //        itemlist = new List<item>();
    //        for (int i = 0; i < num; i++)
    //        {//将每个物品的id和数量存入列表
    //            item item = new item();
    //            item.id = PlayerPrefs.GetInt(playerName+"id"+i);
    //            item.count=PlayerPrefs.GetInt(playerName+"count"+i);
    //            itemlist.Add(item);
    //        }
    //    }
    //}
    //class item
    //{
    //    public int id;
    //    public int count;

    //}
    public class one : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {
            //Player p=new Player();
            //p.Load();
            //for(int i=0;i<p.itemlist.Count; i++)
            //{
            //    print("物品id" + p.itemlist[i].id + "数量" + p.itemlist[i].count);
            //}
            //item i1=new item();
            //i1.id = 1;i1.count = 3;
            //item i2=new item();
            //i2.id = 2;i2.count = 10;
            //item i3=new item();
            //i3.id = 3; i3.count = 5;
            //item i4=new item();
            //i4.id = 4; i4.count = 8;
            ////p.itemlist = new List<item>();
            //p.itemlist.Add(i1);
            //p.itemlist.Add(i2);
            //p.itemlist.Add(i3);
            //p.itemlist.Add(i4);
            //p.Save();

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
