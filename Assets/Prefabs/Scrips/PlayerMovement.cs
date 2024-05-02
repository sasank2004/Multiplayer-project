using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float movementSpeedBase = 1000;

    private Rigidbody2D rb;

    Vector2 movement;

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

     void FixedUpdate()
    {
        rb.velocity=movement*movementSpeedBase* Time.fixedDeltaTime;
        //rb.MovePosition(rb.position + movement * movementSpeedBase * Time.fixedDeltaTime);
    }
}