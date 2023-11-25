using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questioner : MonoBehaviour
{
    public GameObject player;
    CharacterMovement charaMove;
    public GameObject quest;


    void Start()
    {
        charaMove = player.GetComponent<CharacterMovement>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            charaMove.moveSpeed = 0f;
            quest.SetActive(true);
        }  
    }


}
