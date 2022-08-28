using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleBullet : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] Weapon script;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("You shit me!");
        rb.velocity = -transform.right * speed;
    }

    void Update()
    {
        Debug.Log(script.bulletCount);
        if (transform.position.x < -12f)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log(collider.tag);
        Debug.Log("You hit me!");
        script.bulletCount = 3;
        script.isCollected = false;
        Debug.Log(script.bulletCount);
        Destroy(gameObject);

    }
}
