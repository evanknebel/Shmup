using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletVelocity : MonoBehaviour, IPooledObject
{
    PlayerShoot player;
    //public GameObject bullet;
    
    // Use this for initialization
    public void OnObjectSpawn ()
    {
        //player = GetComponent<PlayerShoot>();

        //Vector3 shootdir = (bullet.GetComponent<Rigidbody>().transform.position - player.me.transform.position).normalized;
        //bullet.GetComponent<Rigidbody>().velocity = shootdir.normalized * player.bulletSpeed;
        //bullet.transform.forward = shootdir.normalized;

        Vector3 force = new Vector3(0, 0, 60);
        GetComponent<Rigidbody>().velocity = force;

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
