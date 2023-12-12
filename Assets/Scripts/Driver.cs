using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]  float moveSpeed = 20;
    [SerializeField]  float steerSpeed = 200;
    [SerializeField] float maxSpeed = 30;
    [SerializeField] float slowSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "SpeedUP")
        {
            moveSpeed = maxSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bump")
        {
            moveSpeed = slowSpeed;
        }
    }
    // Update is called once per frame
    void Update()
    {
        move();

    }


    void move()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
