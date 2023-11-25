using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q1Btn : MonoBehaviour
{
    public GameObject questioner;
    BoxCollider2D coll;
    public GameObject quest;
    public GameObject player;
    CharacterMovement charaMove;

    public GameObject gate;
    BoxCollider2D collgate;

    public GameObject girl;

    public GameObject gameOver;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = girl.GetComponent<Animator>();
        charaMove = player.GetComponent<CharacterMovement>();
        coll = questioner.GetComponent<BoxCollider2D>();
        collgate = gate.GetComponent<BoxCollider2D>();
    }

    public void TrueBtn()
    {
        quest.SetActive(false);
        charaMove.moveSpeed = 7f;
        coll.enabled = false;
        gate.SetActive(false);
        collgate.enabled = false;
    }

    public void FalseBtn()
    {
        quest.SetActive(false);
        anim.SetTrigger("die");
        gameOver.SetActive(true);
    }
}
