using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public string name;
    public int damage;
    public int defense;
    public float speedMovement;

    public Text p2Name;
    public Text p2Damage;
    public Text p2Defense;
    public Text p2SpeedMovement;



    private PlayerData player1Data;
    private PlayerData player2Data;
    // Start is called before the first frame update
    void Start()
    {
        player1Data = new PlayerData();
        player1Data.name = name;
        player1Data.damage = damage;
        player1Data.defense = defense;
        player1Data.speedMovement = speedMovement;

        player2Data = new PlayerData();
        player2Data.name = "Arjona P2";
        player2Data.damage = 15;
        player2Data.defense = 10;
        player2Data.speedMovement = 40;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("The player is called: " + player1Data.name);
            Debug.Log(player1Data.name + " has " + player1Data.damage + " attack points.");
            Debug.Log(player1Data.defense + " defense points.");
            Debug.Log("and " + player1Data.speedMovement + " speed points.");
        }

        else if (Input.GetMouseButtonDown(1))
        {
            p2Name.text = player2Data.name;
            p2Damage.text = player2Data.damage.ToString();
            p2Defense.text = player2Data.defense.ToString();
            p2SpeedMovement.text = player2Data.speedMovement.ToString();
        }
    }
}
