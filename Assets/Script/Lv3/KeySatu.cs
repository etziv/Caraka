using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySatu : MonoBehaviour
{
    [SerializeField] public bool key = false;
    private BoxCollider2D collis;

    // Start is called before the first frame update
    void Start()
    {
        collis = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            key = true;
            gameObject.SetActive(false);
            collis.enabled = false;
        }  
    }
}
