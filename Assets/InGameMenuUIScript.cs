using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenuUIScript : MonoBehaviour
{
    public GameObject menuCanvas;

    public void OnButtonPress(string buttonText)

    { 
    switch (buttonText)
        {
            case "MainMenu":
                {
                    SceneManager.LoadScene("MenuScene");
                    break;
                }

            case "Back":
                {
                    menuCanvas.SetActive(false);
                    break;
                }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) 
        {
            menuCanvas.SetActive(!menuCanvas.activeSelf);
        }
    }
}
