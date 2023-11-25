using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TanahUp : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
            anim.SetBool("tanahup", true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision) 
    {
        if (collision.gameObject.name == "Cakra")
        {
            collision.gameObject.transform.SetParent(null);
            anim.SetBool("tanahup", false);
        }    
    }
}
