using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public double healthPoints = 10.0;
    public double playerBulletDamage = 2.0;
    PlayerShoot playerShoot;

    public void OnTriggerEnter(Collider other)
    {
        healthPoints -= playerBulletDamage;
        if (healthPoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start ()
    {
        playerShoot = GetComponent<PlayerShoot>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
