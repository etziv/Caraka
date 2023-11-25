using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDua : MonoBehaviour
{
    [SerializeField] public bool _key = false;
    private BoxCollider2D collis;

    public GameObject gate;
    BoxCollider2D collgate;

    // Start is called before the first frame update
    void Start()
    {
        collis = GetComponent<BoxCollider2D>();
        collgate = gate.GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            _key = true;
            gameObject.SetActive(false);
            collis.enabled = false;
            gate.SetActive(false);
            collgate.enabled = false;
        }  
    }
}
