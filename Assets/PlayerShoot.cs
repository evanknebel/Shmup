using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    //public GameObject target;
    public GameObject projectile;
    public GameObject me;

    public float bulletSpeed;
    public float shootInterval;
    //public float timer;
    // Use this for initialization
    void Start()
    {

    }

    public void Shoot()
    {
        GameObject spawnedThing = Instantiate(projectile);
        Destroy(spawnedThing, shootInterval + 2);
        spawnedThing.transform.position = transform.position + transform.forward * 2;
        
        Vector3 shootDir = (spawnedThing.transform.position - me.transform.position).normalized;
        spawnedThing.GetComponent<Rigidbody>().velocity = shootDir.normalized * bulletSpeed;
        spawnedThing.transform.forward = shootDir.normalized;

        //me.transform.forward = shootDir.normalized;
    }
    // Update is called once per frame
    void Update()
    {
        //timer -= Time.deltaTime;
        //if (timer <= 0 && Input.GetKey(KeyCode.LeftShift))
        //{
        //    shoot();
        //    timer = shootInterval;
        //}
    }
}
