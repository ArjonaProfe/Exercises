using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public string name;
    public int    damage;
    public int    defense;
    public float  speedMovement;

    public void Player(string pName, int pDamage, int pDefense, float pSpeedMovement)
    {
        name = pName;
        damage = pDamage;
        defense = pDefense;
        speedMovement = pSpeedMovement;
    }
}
