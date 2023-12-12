using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] bool hasPackage = false;
    SpriteRenderer spriteRenderer;
    [SerializeField] Color32 colorHasPackage = new Color32 (1,1,1,1);
    [SerializeField] Color32 colorDoNotHasPackage = new Color32(1,1,1,1);
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && hasPackage==false)
        {
            hasPackage = true;
            spriteRenderer.color = colorHasPackage;
            Destroy(collision.gameObject,0.5f);
        }
        else if(collision.tag == "Customer" && hasPackage==true)
        {
            hasPackage = false;
            spriteRenderer.color = colorDoNotHasPackage;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(this.gameObject.name + " kolidował z "+ collision.gameObject.name);
    }
}
