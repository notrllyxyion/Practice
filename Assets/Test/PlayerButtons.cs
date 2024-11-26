
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class PlayerButtons : Base
{

    public int Text =
    public void OnGUI()
    {

       
            
       
    
        if (GUI.Button(new Rect(50, 50, 100, 100), "Button - player 1"))
        {
          
        }

        if (GUI.Button(new Rect(50, 50, 250, 250), "Button - player 2"))
        {
          Text = 
        }




        GUI.Label(new Rect(500, 200, 100, 100), Text.ToString);

    }
}
