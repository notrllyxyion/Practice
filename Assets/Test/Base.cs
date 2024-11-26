using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Base : MonoBehaviour
{
    

    public int p1health = 1522;
    public int p1mana = 1521;
    public int p1attack = 111241;
    public int p1defences = 11124111;
    public int p1speed = 2024522020;

    public int p2health = 124422;
    public int p2mana = 1241;
    public int p2attack = 11124241;
    public int p2defences = 14211111;
    public int p2speed = 20204220;

    public int p3health = 124242;
    public int p3mana = 14242241;
    public int p3attack = 11124241;
    public int p3defences = 1114242111;
    public int p3speed = 2022020;

    public void Stats()
    {
        Debug.Log($"Player 1 Health: {p1health} \r\n Player 1 Mana: {p1mana} \r\n Player 1 Attack: {p1attack} \r\n Player 1 Defence: {p1defences} \r\n Player 1 Speed: {p1speed}");

    }
    public void STats()
    {
        Debug.Log($"Player 2 Health: {p2health} \r\n Player 2 Mana: {p2mana} \r\n Player 2 Attack: {p2attack} \r\n Player 2 Defence: {p2defences} \r\n Player 2 Speed: {p2speed}");

    }
    public void Random()
    {
        Debug.Log($"Player 2 Health: {p2health} \r\n Player 2 Mana: {p2mana} \r\n Player 2 Attack: {p2attack} \r\n Player 2 Defence: {p2defences} \r\n Player 2 Speed: {p2speed}");

    }
}
