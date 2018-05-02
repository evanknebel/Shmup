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
    public int shieldStunTime;
    EnemyShoot enemyShoot;
    public int timer = 0;
    bool isBeingDamaged = false;
    bool isRunningCoroutine = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyBullet")
        {
            isBeingDamaged = true;

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

    IEnumerator ShieldStun()
    {
        isRunningCoroutine = true;

        if ( timer == 0)
        {
            for (; ; timer++)
            {
                timer++;
                if (timer >= 2)
                {
                    isBeingDamaged = false;
                    isRunningCoroutine = false;
                }
                yield return new WaitForSeconds(shieldStunTime);
            }
        }
        else
        {
            timer = 0;
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
        if (isBeingDamaged == true
            &&
            isRunningCoroutine == false)
        {
            StartCoroutine(ShieldStun());
        }
        else if (isBeingDamaged == false)
        {
            if (shield <= shieldMax)
            {
                shield += rechargeSpeed * Time.deltaTime;
            }
            if (shield > shieldMax)
            {
                shield = shieldMax;
            }
            else if (shield < 0)
            {
                shield = 0;
            }
        }
    }
}