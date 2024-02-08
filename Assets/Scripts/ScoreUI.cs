using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    void Update()
    {
        scoreText.text = player.position.x.ToString("0");
    }
}
