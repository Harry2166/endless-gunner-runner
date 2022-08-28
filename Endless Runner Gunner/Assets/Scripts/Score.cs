using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextElement;
    [SerializeField] private float timeStart = 0;
    public PlayerDeath PlayerDeath;
    void Start()
    {
        TextElement.text = timeStart.ToString();
    }

    void Update()
    {
        if (PlayerDeath.isDead)
        {
            timeStart += 0;
            TextElement.text = "Score:" + Mathf.Round(timeStart).ToString();
        }
        else
        {
            timeStart += Time.deltaTime;
            TextElement.text = "Score:" + Mathf.Round(timeStart).ToString();
        }
    }
}
