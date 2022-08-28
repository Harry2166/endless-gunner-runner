using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissedThePart : MonoBehaviour
{
    [SerializeField] private AudioSource Bully_Maguire;
    public PlayerDeath PlayeerDeath;

    void Start()
    {
        Bully_Maguire.Play();
    }

    void Update()
    {
        if (PlayeerDeath.isDead)
        {
            Bully_Maguire.Pause();
        }
    }

}
