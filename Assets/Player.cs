using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 25f;
    //Moves slower when strafing or backing up, making looking at the ghost slow player movement
    public float latSpeed = 15f;
    public float backSpeed = 10f;
 

    // Update is called once per frame
    void Update()
    {

        //This uses key input to change direction of main character.
        //transform was used because it allows forward to be independent of the innate game directions
        //forward instead relies on current way the player is looking

        if (Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.position += transform.forward * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.gameObject.transform.position += transform.forward * Time.deltaTime * -backSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.position += transform.right * Time.deltaTime * -latSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.position += transform.right * Time.deltaTime * latSpeed;
        }

        

    }
}
