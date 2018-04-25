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

    public void Shoot()
    {
        ObjectPoolManager.Instance.SpawnFromPool("PlayerBullet", transform.position + transform.forward * 2, Quaternion.identity);
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
