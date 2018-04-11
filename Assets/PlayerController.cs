using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //   public float speed;
    //   Rigidbody rb;
    //// Use this for initialization
    //void Start ()
    //   {
    //       rb = GetComponent<Rigidbody>();
    //}

    //   // Update is called once per frame
    //   void Update()
    //   {
    //       float vert = Input.GetAxis("Vertical");
    //       float horz = Input.GetAxis("Horizontal");



    //       if (
    //           Input.GetKey(KeyCode.UpArrow)
    //           ||
    //           Input.GetKey(KeyCode.DownArrow)
    //           ||
    //           Input.GetKey(KeyCode.LeftArrow)
    //           ||
    //           Input.GetKey(KeyCode.RightArrow)
    //          )
    //       {
    //           Vector3 verthorzvec = new Vector3(horz, 0, vert);
    //           rb.AddForce(verthorzvec * speed);
    //       }
    //       else
    //       {
    //           //rb.velocity.magnitude
    //           /*
    //           Vector3 verthorzvec = new Vector3(-horz, 0, -vert);
    //           rb.AddForce(verthorzvec * speed);
    //           */
    //       }





    //   }

    public float speed;
    public float timer;

    PlayerMotor motor;
    PlayerShoot gun;

    void Start()
    {
        motor = GetComponent<PlayerMotor>();
        gun = GetComponent<PlayerShoot>();
    }

    void Update()
    {
        //stuff to move around
        float Xmove = Input.GetAxis("Horizontal");
        float Zmove = Input.GetAxis("Vertical");

        Vector3 moveHorizontal = transform.right * Xmove;
        Vector3 moveVertical = transform.forward * Zmove;

        Vector3 velocity = (moveHorizontal + moveVertical) * speed;

        motor.Move(velocity);

        timer -= Time.deltaTime;
        if (timer <= 0 && Input.GetKey(KeyCode.LeftShift))
        {
            gun.Shoot();
            timer = gun.shootInterval;
        }

    }
}