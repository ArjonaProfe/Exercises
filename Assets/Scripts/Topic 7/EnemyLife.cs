using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    private Rigidbody rb;
    public int life = 100;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public int Damage(int lifePoints)
    {
        life = life - lifePoints;
        Debug.Log(life);

        if (life <= 0)
        {
            Destroy(gameObject);
        }
        return life;
    }


}
