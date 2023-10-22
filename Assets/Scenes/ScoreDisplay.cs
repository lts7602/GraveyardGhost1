using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreCounter : MonoBehaviour
{
    private TMP_Text uiText;
    public float actScore;
    // Start is called before the first frame update
    void Start()
    {
        uiText= GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        actScore = GameManager.score + Time.timeSinceLevelLoad; 
        uiText.text =" Time: " +actScore.ToString("F2");
    }
}

