using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTimer : MonoBehaviour
{
    public GameObject trigger;
    // Start is called before the first frame update

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            trigger.SetActive(false);
            Invoke("activetrigger", 5f);
        }
    }

    public void activetrigger()
    {
        trigger.SetActive(true);
    }
}
