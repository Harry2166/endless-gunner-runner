using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour { 

    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    private float y_value = -3.485f;


// Use this for initialization
    void Start() {
    rb = this.GetComponent<Rigidbody2D>();
    rb.velocity = new Vector2(-speed, y_value);
    screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
}

// Update is called once per frame
    void Update() {
    if (transform.position.x < -12f)
    {
        Debug.Log(transform.position.x);
        Destroy(this.gameObject);
    }
}
}
