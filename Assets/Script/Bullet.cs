using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody bulletRigidbody;

    public float BulletSpeed = 40f;

    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * BulletSpeed;
    }
}

