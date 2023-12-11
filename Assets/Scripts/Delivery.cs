using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] bool hasPackage = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && hasPackage==false)
        {
            hasPackage = true;
            this.GetComponent<SpriteRenderer>().color = Color.blue;
            Destroy(collision.gameObject);
        }
        else if(collision.tag == "Customer" && hasPackage==true)
        {
            hasPackage = false;
            this.GetComponent<SpriteRenderer>().color = Color.green;
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(this.gameObject.name + " kolidował z "+ collision.gameObject.name);
    }
}
