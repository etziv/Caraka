using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLv : MonoBehaviour
{
    private AudioSource finlv;
    public AudioSource backsound;
    // Start is called before the first frame update
    void Start()
    {
        finlv = GetComponent<AudioSource>();
        backsound = backsound.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (backsound.isPlaying)
            {
                backsound.Stop();
            }
            finlv.Play();
            Invoke("NextLevel", 3f);
        }
    }
    // Update is called once per frame
    private void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
