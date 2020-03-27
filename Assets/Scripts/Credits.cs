using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public GameObject panel;
    public GameController gc;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }
    
    public void OpenWindow()
    {
        panel.SetActive(true);
        gc.PauseGame();
    }

    public void CloseWindow()
    {
        panel.SetActive(false);
        gc.ContinueGame();
    }

}
