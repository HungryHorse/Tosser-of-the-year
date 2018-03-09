using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tossing : MonoBehaviour {

    public int power;
    public GameObject Projectile;
    Transform spawnpoint;

	void Update () {
		
	}

    void Shoot()
    {
        GameObject newBall = Instantiate(Projectile, spawnpoint);

        Rigidbody2D rigidBody = newBall.AddComponent<Rigidbody2D>();
        rigidBody.AddForce(new Vector2(power,0));
    }
}
