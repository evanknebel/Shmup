using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDeactivationBarrier : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyBullet"
            ||
            other.gameObject.tag == "PlayerBullet")
        {
            other.gameObject.SetActive(false);
        }

    }


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
