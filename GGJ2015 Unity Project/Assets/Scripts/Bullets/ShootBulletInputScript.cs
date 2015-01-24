﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(ShootBulletScript))]
public class ShootBulletInputScript : MonoBehaviour {

    ShootBulletScript shooter;
    
    public Vector2 relativeFirePosition;

    void Start()
    {
        shooter = GetComponent<ShootBulletScript>();
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            shooter.FireBullet(transform.right, relativeFirePosition, true);
        }
	}
}