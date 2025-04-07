using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    AudioSource audiosource;
    public AudioClip audioclip;
    // Start is called before the first frame update
    void Start()
    {
        audiosource=this.gameObject.AddComponent<AudioSource>();
        audiosource.clip= audioclip;
        audiosource.Play();
    }
    
    // Update is called once per frame
    void Update()
    {
        

    }
}
