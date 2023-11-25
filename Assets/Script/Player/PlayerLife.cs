using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    public AudioSource backsound;
    public GameObject gameOver;
    public AudioSource gOver;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        gOver = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }    
    }

    private void Die()
    {
        gameOver.SetActive(true);
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("die");
        if(backsound.isPlaying)
        {
            backsound.Stop();
            gOver.Play();
        }
    }


}
