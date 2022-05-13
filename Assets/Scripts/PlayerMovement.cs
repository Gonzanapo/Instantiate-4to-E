using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 playerPosition;
    public float rotationSpeed;
    public float movementSpeed;
    public KeyCode left;
    public KeyCode up;
    public KeyCode right;
    public KeyCode down;
    public KeyCode atras;
    public KeyCode adelante;

    // Start is called before the first frame update
    void Start() {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
          transform.position += new Vector3(-movementSpeed, 0,0);
        }
        else if (Input.GetKey(right))
        {
            transform.position += new Vector3(-movementSpeed, 0, 0);
        }
        else if (Input.GetKey(up))
        {
            transform.position += new Vector3(0, movementSpeed, 0);
        }
        else if (Input.GetKey(down))
        {
            transform.position += new Vector3(0, -movementSpeed, 0);
        }
        else if (Input.GetKey(atras))
        {
            transform.position += new Vector3(0, 0, -movementSpeed);
        }
        else if (Input.GetKey(adelante))
        {
            transform.position += new Vector3(0, 0, movementSpeed);
        }

        //transform.eulerAngles += new Vector3(0, rotationSpeed, 0);
        //transform.localScale += new Vector3(0.1f, 0, 0);
    }
}
