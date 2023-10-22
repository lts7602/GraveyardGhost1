using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreFinal : MonoBehaviour
{
    // Start is called before the first frame update
    private TMP_Text uiText;
    public bool TF;
    
    void Start()
    {
        //This simple true false allowed me to use this script for both score and highscore without making a second script.
        //It's applied to the score boxes throughout the game to show the player their score.
        if(TF == true){
            uiText= GetComponent<TMP_Text>();

            uiText.text ="Your time was: " +GameManager.score.ToString("F2");
        }
        if(TF == false){
            uiText= GetComponent<TMP_Text>();

            uiText.text ="Highscore: " +GameManager.highScore.ToString("F2");
        }
        

        
    }


}
