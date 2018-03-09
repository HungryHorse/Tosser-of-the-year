using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tossing : MonoBehaviour {

    public int power;
    public float angle;
    public GameObject Projectile;
    public Transform spawnpoint;

	void Update () {
		
	}

    void Shoot()
    {
        Instantiate(Projectile, spawnpoint);
    }
}
