using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame()
    {
        if (Input.GetMouseButtonUp(0))
            Application.Quit();
    }

    public void StartGame()
    {
        if (Input.GetMouseButtonUp(0))
            SceneManager.LoadScene("MainScene");
    }

    public void SettingGame()
    {
        if (Input.GetMouseButtonUp(0))
            SceneManager.LoadScene("MainScene");
    }

    public void Developer()
    {
        if (Input.GetMouseButtonUp(0))
            SceneManager.LoadScene("MainScene");
    }
}
