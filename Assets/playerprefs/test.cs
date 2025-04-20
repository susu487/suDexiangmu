using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player
{
    public Dictionary<int, string> dic = new Dictionary<int, string>()
    {
        { 1,"aaa" }
    };
    
    public item i=new item(3,"bear");
    public List<item> list = new List<item>()
    {
        new item(1,"apple"),
        new item(2,"banana")
    };
    
}
public class item
{
    public int id;
    public string name;

    public item()
    {

    }
    public item(int id, string name)
    {
        this.id = id;
        this.name = name;

    }
    public class test : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            player player = new player();

            project.Instance.SaveDate(player, "p1");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
