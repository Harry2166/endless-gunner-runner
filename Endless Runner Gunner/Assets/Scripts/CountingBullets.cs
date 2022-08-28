using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingBullets : MonoBehaviour
{
    [SerializeField] Weapon Script;
    public int bulletCount = 3;
    public bool isCollected = false;
}
