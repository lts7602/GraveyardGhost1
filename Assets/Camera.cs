using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float horizontalSpeed = 5f;
    public GameObject Player;
    public Camera cameraObj;


    // Update is called once per frame
    void Update()
    {
        //updates on mouse drag
        if (Input.GetMouseButton(0))
        {
            //rotates the camera around the player, giving a third person perspective in the game
            Player.transform.RotateAround(Player.transform.position,
                                            Vector3.up,
                                            Input.GetAxis("Mouse X") * horizontalSpeed);

        }
    }
}
