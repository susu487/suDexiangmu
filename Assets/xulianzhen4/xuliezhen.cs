using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xuliezhen : MonoBehaviour
{
    public Sprite[] spr;
    public SpriteRenderer sprRenderer;
    public int index = 0;
    public float time = 0f;
    public float resetTime = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        sprRenderer = GetComponent<SpriteRenderer>();
        sprRenderer.sprite = spr[index];
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > resetTime)
        {
            time = 0f;
            index++;
            if (index >= spr.Length)
            {
                index = 0;
            }
            sprRenderer.sprite = spr[index];
        }
    }
}
