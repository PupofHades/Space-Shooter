using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxspeed =5f;
    public float rotSpeed =400f;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotation
        
        //Grabs rotation quaternion
        Quaternion rot = transform.rotation;

        //Grabs z angle
        float z = rot.eulerAngles.z;

        //Changes z angle based on input
        z -= Input.GetAxis("Horizontal")* rotSpeed * Time.deltaTime;

        //Recreate the quarternion
        rot = Quaternion.Euler(0,0,z );

        //Feed the quarternion into rotation
        transform.rotation = rot;

        //Moving forward and backwards
        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxspeed * Time.deltaTime, 0);

        pos += rot * velocity;
        transform.position = pos;


    }
}
