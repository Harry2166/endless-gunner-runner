using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{

    private Animator anim;
    private Rigidbody2D rb;
    [SerializeField] private AudioSource death_sound_effect;
    //public GameOverScreen GameOverScreen;
    public bool isDead;
    public bool deathAnimation = false;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Time.timeScale < 1 && deathAnimation == false) {
            Time.timeScale += 0.001f;
            if(Time.timeScale > 0.6f)
            {
                deathAnimation = true;
                Time.timeScale = 0;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            death_sound_effect.Play();
            Time.timeScale = 0;
            Die();
        }
    }
    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
        isDead = true;
    }

    public void Dead()
    {
        isDead = true;
    }

    public void GameOver()
    {
        //Dead();
        //GameOverScreen.Setup();
    }

}


