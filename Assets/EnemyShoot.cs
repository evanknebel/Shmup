using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public void Update()
    {
        GameObject newBullet = ObjectPoolManager.Instance.SpawnFromPool("EnemyBullet", transform.position + transform.forward * 2, Quaternion.identity);
    }
}
