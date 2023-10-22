using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Weeping_Angel : MonoBehaviour
{
    // Start is called before the first frame update
    //private Transform target;
    public GameObject Player;
    public float speed = 33f;
    public Transform target;
    public bool isCurrentlyColliding = false;

    //public string deathScene;

    void OnTriggerEnter(Collider other)
    {
        //Stops ghost movement if a player or statue is looking at it
        if (other.tag == "Vision" ||other.tag=="Statue")
        {
            isCurrentlyColliding = true;  

        }
        //any contact with player kills the player and plays the death scene
        if(other.tag=="Player"){
            //Passer.score = 0;
            //SceneManager.LoadScene(deathScene);
            GameManager.instance.updateGameState(GameState.YOUDIED);
        }
    }

    void OnTriggerExit(Collider other)
    {
        //frees ghost from being frozen
        if (other.tag == "Vision")
        {
            isCurrentlyColliding = false;

        }
        
    }


    void Update()
    {
        //This code will move the ghost and make him look at the player, but only while not frozen.
       if (isCurrentlyColliding==false) {
            Vector3 pos = Player.transform.position;
            var step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, pos, step); 
            transform.LookAt(target);
        }


              
    }
}
