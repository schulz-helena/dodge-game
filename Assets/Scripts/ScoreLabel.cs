using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ScoreLabel : MonoBehaviour
{
    TMP_Text text;

    void Awake()
    {
        text = GetComponent<TMP_Text>();

    }

    void Update()
    {
        text.text = "Score: " + ScoreManager.instance.score;
    }
}
