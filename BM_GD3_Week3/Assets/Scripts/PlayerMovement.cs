using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float horizontalInput;
    public int xRange = 18;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position(0,0,15.54); ??
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(moveSpeed * Time.deltaTime * horizontalInput,0,0);

        if (transform.position.x <= -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }

        if (transform.position.x >= xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y,transform.position.z);
        }
    }
}
