using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    private void Start()
    {
        
    }

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void credits()
    {
        SceneManager.LoadScene(4);
    }

    public void Main()
    {
        SceneManager.LoadScene(0);
    }
}
