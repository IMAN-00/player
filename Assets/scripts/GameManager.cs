using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Player red = new Player();
    Player yellow = new Player();
    void Start()
    {
      red.InitializePlayer("red", 40);
      yellow.InitializePlayer("yellow", 70);
      Debug.Log(red.name + " " +red.health);
      Debug.Log(yellow.name + " " +yellow.health);
      Debug.Log(Player.PlayerCount);
      red.Heal(60);
      yellow.Heal(true);
      
    }
    

}
