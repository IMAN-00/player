using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{

    public string name;
    public int health;
    static public int PlayerCount = 0;

    public void InitializePlayer(string PlayerName, int PlayerHealth)
      {
         name = PlayerName;
         health = PlayerHealth;
         PlayerCount++;
      }
    public void Heal(int amount)
      {
         health += amount;
         Debug.Log( name + "healed" + amount + "points.current health:" + health);
      }
    public void Heal(bool FullRestore)
      {
         if (FullRestore) 
         health = 100;
         Debug.Log(name + "current health" + health );
      }
    static public int ShowPlayerCount()
      {
         Debug.Log( "Total players:" +PlayerCount);
         return PlayerCount;
      }

}