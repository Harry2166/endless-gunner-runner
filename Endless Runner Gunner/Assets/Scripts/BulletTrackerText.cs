using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BulletTrackerText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextElement;
    public Weapon Weapon;

    void Update()
    {
        TextElement.text = "Bullets: " + Weapon.bulletCount;
    }
}
