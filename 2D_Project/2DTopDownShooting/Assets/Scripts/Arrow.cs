using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private Rigidbody2D movementRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        ApplyMovement();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ApplyMovement()
    {
        movementRigidbody.velocity = transform.right * 8f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
