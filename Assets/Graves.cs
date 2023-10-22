using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graves : MonoBehaviour
{
    public GameObject gravePrefab;
    public float xOff = 20f;
    public float xmin = -90f;
    public float zmin = -80;
    public float zOff = -40;

    // Start is called before the first frame updated
    void Start()
    {
            //using a nested for loop, I spawn in the grave gameobject 50 times in a grid to make the graveyard
            //This is simpler than placing each one manually
            for(int i=0; i<10; i++){
                for(int j=0; j<5; j++){

                GameObject grave = Instantiate<GameObject>(gravePrefab);
                Vector3 pos = Vector3.zero;

                pos.x = xmin +i*xOff;
                pos.z= zmin +j*zOff;
                pos.y=3f;
                
                grave.transform.position = pos;


                }
            }
       
    }

}
