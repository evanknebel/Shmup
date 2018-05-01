using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public double shieldMax;
    public double shield;
    public double rechargeSpeed;
    public double healthPoints;
    public double enemyBulletDamage;
    EnemyShoot enemyShoot;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyBullet")
        {
            shield -= enemyBulletDamage;
            if(shield <= 0)
            {
                healthPoints -= enemyBulletDamage * 1.5;
                if (healthPoints <= 0)
                {
                    Destroy(gameObject);
                }
            }
            
        }
    }

    // Use this for initialization
    void Start()
    {
        enemyShoot = GetComponent<EnemyShoot>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shield <= shieldMax)
        {
            shield += rechargeSpeed * Time.deltaTime;
        }
        if (shield > shieldMax)
        {
            shield = shieldMax;
        }
        else if (shield <= 0)
        {
            shield = 0;
        }
    }
}