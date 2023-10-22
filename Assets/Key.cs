using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Key : MonoBehaviour
{

    public GameObject key;
    public bool unlocked = true;

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene ();
		string sceneName = currentScene.name;

		if (sceneName == "Level2") 
		{
            unlocked=false;
		
            //spawns key and locks door
            Vector3 pos = Vector3.zero;

            //This sets the position to right behind one of the graves
            //The random numbers are the "index" to choose which grave
            int i = Random.Range(0, 10);
            int j = Random.Range(0, 5);

            //These scalars work by using the original and x offsets of the graves and multiplying them by the indexed grave
            //in order to set the key 1 z unit behind

            //It was simpler to hide the key beneath the level and move it on level 2 rather than instantiate it and then set a random position
            pos.x = i*20 - 90;
            pos.z = j*-40 + 81;
            pos.y = 3f;
            key.transform.position= pos;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        //the player touching the key will unlock the door
        if (other.tag == "Player")
        {
            //sets the win condition so the door triggers win scene
            unlocked= true;

            //This section sets the key position to the door to give an indication that the door is open
            Vector3 pos = Vector3.zero;
            pos.x = 0;
            pos.z = 99;
            pos.y = 3;

            key.transform.position= pos;

        }
    }

}
