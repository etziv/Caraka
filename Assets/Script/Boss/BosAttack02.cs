using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BosAttack02 : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            anim.SetTrigger("attack02");
        }
    }
}
