using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack3 : MonoBehaviour
{
    public GameObject boss;
    Animator animboss;
    Animator animduri;
    // Start is called before the first frame update
    void Start()
    {
        animboss = boss.GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            animboss.SetTrigger("attack");
        }
    }

}
