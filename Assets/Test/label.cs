using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class label : PlayerButtons 
{
    public int health;

    private void OnGUI()
    {
        GUI.Label(new Rect(500, 500, 100, 100), health.ToString());
       
            
       
    }
}
