using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{

    public string name;
    public int health = 100;
    static public int PlayerCount = 0;
 
    public void Player(string PlayerName)
      {
          name = PlayerName ;
         health = 100;
         PlayerCount++;
      }
      
    public void Heal(int amount)
      {
         healh += amount;
         Debug.Log( PlayerName + "healed" + amount + "points.current health:" + health);
      }
    public void Heal(bool FullRestore)
      {
         if (FullRestore) 
         health = 100;
         Debug.Log("Players" + PlayerName + "current health" + health );
      }
    static public int ShowPlayerCount()
      {
         Debug.Log( "Total players:" +PlayerCount);
      }

}