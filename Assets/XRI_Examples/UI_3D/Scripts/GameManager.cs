using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Timer _timerScript;

    private void Start()
    {
        _timerScript = GameObject.Find("Canvas Timer").GetComponent<Timer>();
    }
    public void QuitGame()
    {
        Debug.Log("You Quit");
        Application.Quit();
    }

}
