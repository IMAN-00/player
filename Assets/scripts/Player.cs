using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
 public string name = " ";
 private int health = 100;
 static public int PlayerCount = 0;
}
public void InitializePlayer()
{
    PlayerName = name;
    health = InitialHealth;
    return PlayerName;
    PlayerCount++;
}
public void Heal(int amount)
{
    healh += amount;
    Debug.Log(health = health + amount);
}
public void FullRestore(bool)
{
    if (FullRestore) 
    health = 100;
    Debug.log( PlayerName + "current health" + health );
}
static public int PlayerCount()
{
    Debug.log(players: " " + PlayerCount);
}