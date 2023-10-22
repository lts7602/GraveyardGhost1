using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public void newGame(){
        GameManager.instance.updateGameState(GameState.Level1);
       //SceneManager.LoadScene(newGameScene);
        //Passer.score = 0;
    }


    public void voidLevel2(){
        //SceneManager.LoadScene(level2Scene);
        GameManager.instance.updateGameState(GameState.Level2);
    }

    public void mainMenu(){
        GameManager.instance.updateGameState(GameState.Begin);
        //SceneManager.LoadScene(mainMenuScene);
        //Passer.score = 0;
    }
    public void instructions(){
        //SceneManager.LoadScene(instructionScene);
        GameManager.instance.updateGameState(GameState.Instructions);
    }


    public void credits(){
        GameManager.instance.updateGameState(GameState.Credits);
    }

    public void quitGame(){
        Application.Quit();

    }
}
