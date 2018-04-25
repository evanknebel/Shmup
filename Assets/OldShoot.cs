using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject target;
    public GameObject myPrefab;
    public GameObject me;

    public float speed;
    public float shootInterval;
    float timer;
    // Use this for initialization
    void Start()
    {

    }

    public void spawnThing()
    {
        GameObject spawnedThing = Instantiate(myPrefab);
        Destroy(spawnedThing, shootInterval + 2);
        spawnedThing.transform.position = transform.position;
        Vector3 shootDir = (target.transform.position - spawnedThing.transform.position).normalized;
        spawnedThing.GetComponent<Rigidbody>().velocity = shootDir.normalized * speed;
        spawnedThing.transform.forward = shootDir.normalized;

        me.transform.forward = shootDir.normalized;
    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            spawnThing();
            timer = shootInterval;
        }
    }
}
