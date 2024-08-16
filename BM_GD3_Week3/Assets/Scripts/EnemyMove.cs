using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public int health;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);

        if (transform.localPosition.z >= 18)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, 1);
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }

       
    }
}
