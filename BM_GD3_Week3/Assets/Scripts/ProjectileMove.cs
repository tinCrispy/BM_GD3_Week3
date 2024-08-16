using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public float projectileSpeed;
    public float rotationSpeed = 360;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * projectileSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Random.Range(-rotationSpeed, rotationSpeed) * Time.deltaTime, 
                         Random.Range(-rotationSpeed, rotationSpeed) * Time.deltaTime, 
                         Random.Range(-rotationSpeed, rotationSpeed) * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "animal")
        {
            Destroy(gameObject, 0);
            collision.transform.GetComponent<EnemyMove>().health -= 1;
        }
    }
}