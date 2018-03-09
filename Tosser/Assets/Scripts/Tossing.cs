using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tossing : MonoBehaviour {

    public int power;
    public GameObject Projectile;
    Transform spawnpoint;
    public GameObject Sphere;
   
	void Update () {

        spawnpoint = Sphere.transform;


        if (Input.GetButtonDown("Jump"))
        {
            Shoot();
        }
	}

    void Shoot()
    {
        GameObject newBall = Instantiate(Projectile, spawnpoint);

        Rigidbody2D newRigidBody = newBall.AddComponent<Rigidbody2D>();

        newRigidBody.AddForce(new Vector2(power,0));
    }
}
