using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public GameObject boss;
    public GameObject duri;
    // private GameObject trigger;
    Animator animboss;
    Animator animduri;
    // Start is called before the first frame update
    void Start()
    {
        animboss = boss.GetComponent<Animator>();
        animduri = duri.GetComponent<Animator>();
        // trigger = GetComponent<GameObject>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            animboss.SetTrigger("attack");
            animduri.SetTrigger("DuriAtt");
            // StartCoroutine(ExampleCoroutine());
        }
    }

    // IEnumerator ExampleCoroutine()
    // {
    //     trigger.SetActive(false);
    //     yield return new WaitForSeconds(5);
    //     trigger.SetActive(true);
    // }

}
