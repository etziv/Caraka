using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnNotif : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject notif;
    AudioSource main;
    public GameObject maincam;
    // Start is called before the first frame update
    void Start()
    {
        main = maincam.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (main.isPlaying)
            {
                main.Stop();
            }
            notif.SetActive(true);
        }
    }

    public void BtnNextLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BtnRestart()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BtnExit()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void BtnNewGame()
    {
        SceneManager.LoadScene("Lv1_Cakra");
    }

}
