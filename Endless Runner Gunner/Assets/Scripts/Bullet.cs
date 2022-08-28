using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject impactEffect;
    [SerializeField] private AudioSource bullet_hit_sound_effect;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void Update()
    {
        if (transform.position.x > 12f)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D()
    {
        bullet_hit_sound_effect.Play();
        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
