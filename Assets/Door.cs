using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public GameObject key;
    public bool unlocked;

    void start(){
        //gets "key" for whether door is open or not
        unlocked=  key.GetComponent<Key>().unlocked;
        
    }

    //When the player touches the door, they're safe from the ghosts and they win
    //this only happens if the door is unlocked though
    void OnTriggerEnter(Collider other)
            {

                unlocked = key.GetComponent<Key>().unlocked;
                if (other.tag == "Player" && unlocked)
                {
                    GameManager.score += Time.timeSinceLevelLoad;
                    
                    GameManager.instance.updateGameState(GameState.Win);

                }
            }

    
}
