using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donghua1 : MonoBehaviour
{
    private Animation Animation;
    [Header("¿Õ¸ñ£¨ÂÒ×ß£©")]
    public string animationName1;
    [Header("w")]
    public string animationName2;
    [Header("A")]
    public string animationName3;
    [Header("S")]
    public string animationName4;
    [Header("D")]
    public string animationName5;
    // Start is called before the first frame update
    void Start()
    {
        Animation=GetComponent<Animation>();
    }

    void print()
    {
        Debug.Log("123");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Animation.Play(animationName1);
            
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Animation.CrossFade(animationName2);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Animation.PlayQueued(animationName3);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Animation.CrossFadeQueued(animationName4);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Animation.Play(animationName5);
        }
    }
}
