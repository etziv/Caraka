using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nogo : MonoBehaviour
{
    [SerializeField] public GameObject nogo;
    Animator anim;

    void Start()
    {
        nogo = GameObject.Find("Dino");
        anim = nogo.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D (Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            anim.SetBool("Dino", true);
        }
    }
}
