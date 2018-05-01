using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletVelocity : MonoBehaviour, IPooledObject
{
    public float velocity;

    // Use this for initialization
    public virtual void OnObjectSpawn()
    {

        Vector3 force = new Vector3(0, 0, -velocity);
        GetComponent<Rigidbody>().velocity = force;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
