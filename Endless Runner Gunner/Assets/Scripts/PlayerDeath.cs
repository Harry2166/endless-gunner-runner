using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{

    //private Animator anim;
    private Rigidbody2D rb;
    //[SerializeField] private AudioSource death_sound_effect;
    //public GameOverScreen GameOverScreen;
    public bool isDead;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            //death_sound_effect.Play();
            Debug.Log("I Died!");
            Die();
        }
    }
    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        //anim.SetTrigger("death");
    }

    public void Dead()
    {
        isDead = true;
    }

    public void GameOver()
    {
        Dead();
        //GameOverScreen.Setup();
    }

}


