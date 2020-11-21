using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float playerLocX;
    float playerLocY;
    float playerLocZ;
    public float moveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        playerLocX = gameObject.transform.position.x;
        playerLocY = gameObject.transform.position.y;
        playerLocZ = gameObject.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        playerLocY = gameObject.transform.position.y;
        if(Input.GetKey("w"))
        {
            playerLocZ += moveSpeed;
            gameObject.transform.position = new Vector3(playerLocX, playerLocY, playerLocZ);
        }
        if (Input.GetKey("s"))
        {
            playerLocZ -= moveSpeed;
            gameObject.transform.position = new Vector3(playerLocX, playerLocY, playerLocZ);
        }
        if (Input.GetKey("a"))
        {
            playerLocX -= moveSpeed;
            gameObject.transform.position = new Vector3(playerLocX, playerLocY, playerLocZ);
        }
        if (Input.GetKey("d"))
        {
            playerLocX += moveSpeed;
            gameObject.transform.position = new Vector3(playerLocX, playerLocY, playerLocZ);
        }
    }
}
