using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameState State;

    public static float score=1;
    public static float highScore=999;
    //public static event Action<GameState> OnGameStateChanged;

    void Awake(){
        if(instance ==null){
            instance = this;
        }
        else{
            Destroy(gameObject);
        }

    }
    public void updateGameState(GameState newState){
        State = newState;

        Scene currentScene = SceneManager.GetActiveScene ();
	    string sceneName = currentScene.name;

        switch(newState){

            case GameState.Begin:
                if(sceneName != "Begin"){
                    SceneManager.LoadScene("Begin");
                }
                
                score=0;
                break;

            case GameState.Instructions:
                SceneManager.LoadScene("Instructions");

                break;

            case GameState.Level1:
                SceneManager.LoadScene("Level1");
                break;

            case GameState.Level2:
                SceneManager.LoadScene("Level2");
                break;

            case GameState.Win:
                if(sceneName == "Level1"){
                        SceneManager.LoadScene("Level1Win");
                    }

                if(sceneName == "Level2"){

                        if(GameManager.score < GameManager.highScore){
                            GameManager.highScore= GameManager.score;
                        }

                        SceneManager.LoadScene("Win");
                    }
                
                break;

            case GameState.YOUDIED:
                score=0;
                SceneManager.LoadScene("YOUDIED");
                break;

            case GameState.Escaped:
                print("Heard chef");
                Application.Quit();
                break;
            
            case GameState.Credits:
                SceneManager.LoadScene("Credits");
                break;
            default:
                //throw new ArgumentOutOfRange(nameof(newState), newState, null);
                break;
            
        }
        //OnGameStateChanged?.Invoke(newState);

    }


    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
             GameManager.instance.updateGameState(GameState.Escaped);
        }
    }


}
public enum GameState{
    Begin,
    Instructions,
    Level1,
    Level2,
    Win,
    YOUDIED,
    Escaped,
    Credits
}
