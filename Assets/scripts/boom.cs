using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class boom : MonoBehaviour
{
    Rigidbody rb;
    public int force=20;
    // Start is called before the first frame update
    void Start()
    {
        rb=this.GetComponent<Rigidbody>();
        rb.AddExplosionForce(force,Vector3.zero,10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
