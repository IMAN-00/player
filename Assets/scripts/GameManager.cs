using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Player red;
    Player yellow;
    void Start()
    {
      
      red = new Player("red", 40);
      yellow = new Player("yellow", 70);
      Debug.Log(red.name + " " +red.health);
      Debug.Log(yellow.name + " " +yellow.health);
      Debug.Log(Player.PlayerCount);
      red.Heal(60);
      yellow.Heal(true);
      
    }
    

}
