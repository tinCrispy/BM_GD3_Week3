using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float strafeSpeed;
    public float moveSpeed;
    public float horizontalInput;
    public float verticalInput;
    public int xRange = 18;
    public GameObject[] projectile;


    // Start is called before the first frame update
    void Start()
    {
        //transform.position(0,0,15.54); ??
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * -horizontalInput * strafeSpeed * Time.deltaTime);

        if (transform.position.x <= -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }

        if (transform.position.x >= xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y,transform.position.z);
        }

        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * -verticalInput * moveSpeed * Time.deltaTime);

        if(transform.position.z >= 16)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 16);
        }

        if (transform.position.z <= 13)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 13);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            int ProjectileIndex = Random.Range(0, projectile.Length);
            Instantiate(projectile[ProjectileIndex], transform.position + new Vector3(0, 1, 0), projectile[ProjectileIndex].transform.rotation);

        }

        
    }

}
