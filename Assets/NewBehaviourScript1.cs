using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public Rect Rect = new Rect(10, 10, 100, 100);
    public bool duibu = true;
    public GUIStyle GUIStyle;
    public GUIContent a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {

        duibu=GUI.Toggle(Rect, duibu, "hahahsudhbsdvsd",GUIStyle);

    }
}
