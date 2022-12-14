using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour { 

    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    [SerializeField] private GameObject impactEffect;
    [SerializeField] private AudioSource bullet_hit_sound_effect;


    // Use this for initialization
    void Start() {
    rb = this.GetComponent<Rigidbody2D>();
    rb.velocity = new Vector2(-speed, 0);
    screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
}

// Update is called once per frame
    void Update() {
    if (transform.position.x < -12f){
        Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.tag == "Projectile")
        {
            bullet_hit_sound_effect.Play();
            Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

}
