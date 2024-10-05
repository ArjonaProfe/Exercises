using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerArray : MonoBehaviour
{
    private List<PlayerData> players;
  
    public string[] names;
    public int[] damage;
    public int[] defense;
    public int[] speed;

    public Text[] p1Texts;
    public Text[] p2Texts;

    // Start is called before the first frame update
    void Start()
    {
        players = new List<PlayerData>();
        players.Add(new PlayerData());
        players.Add(new PlayerData());        
      
        SetPlayers();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShowPlayerStats();
        }
    }
    void SetPlayers()
    {        
            players[0].name = names[0];
            players[0].damage = damage[0];
            players[0].defense = defense[0];
            players[0].speedMovement = speed[0];

            players[1].name = names[1];
            players[1].damage = damage[1];
            players[1].defense = defense[1];
            players[1].speedMovement = speed[1];        
    }
    void ShowPlayerStats()
    {
        p1Texts[0].text = players[0].name;
        p1Texts[1].text = players[0].damage.ToString();
        p1Texts[2].text = players[0].defense.ToString();
        p1Texts[3].text = players[0].speedMovement.ToString();

        p2Texts[0].text = players[1].name;
        p2Texts[1].text = players[1].damage.ToString();
        p2Texts[2].text = players[1].defense.ToString();
        p2Texts[3].text = players[1].speedMovement.ToString();
    }
}
