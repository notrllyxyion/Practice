
using UnityEngine;

public class PlayerButtons : Base
{

    public void OnGUI()
    {



        if (GUI.Button(new Rect(20, 50, 100, 100), "Button - player 1"))
        {
            overallstats = $"Health: {p1health} \r\n Mana {p1mana} \r\n Attack: {p1attack} \r\n Defense: {p2defences} \r\n Speed: {p2speed}";
        }

        if (GUI.Button(new Rect(750, 100, 250, 250), "Button - player 2"))
        {
            overallstats = $"Attack: {p2health} \r\n Mana {p2mana} \r\n Attack: {p2attack} \r\n Defense: {p2defences} \r\n Speed: {p2speed}";
        }

        if (GUI.Button(new Rect(90, 750, 150, 150), "Button - player 33"))
        {

        }



        GUI.Label(new Rect(500, 200, 500, 500), overallstats.ToString());

    }
}
