using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnMainMenu : MonoBehaviour
{
    // Start is called before the first frame updat

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey ("escape")) {
            Application.Quit();
        }
    }

        public void OnClickBtnPlay(){
        SceneManager.LoadScene("CharacterPick");
    }

    public void OnClickBtnExit(){
        Application.Quit();
    }
}
