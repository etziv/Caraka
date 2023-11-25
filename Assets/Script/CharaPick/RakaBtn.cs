using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RakaBtn : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("level1_Raka"); //the index of the seconf scene
    }
}
