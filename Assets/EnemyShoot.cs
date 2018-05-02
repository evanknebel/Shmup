using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public float timer;
    public float shootInterval;

    public void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            GameObject newBullet = ObjectPoolManager.Instance.SpawnFromPool("EnemyBullet", transform.position + transform.forward * 2, Quaternion.identity);
            timer = shootInterval;
        }
        
    }
}
