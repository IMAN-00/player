using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{

    public string name;
    public int health = 100;
    static public int PlayerCount = 0;
 
    public string InitializePlayer()
      {
         return name;
      }
    public int InitialHealth()
      {
         return health;
      }
    public void PlayerName(string PlayerName, int health)
      {
         name = PlayerName;
         health = 100;
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