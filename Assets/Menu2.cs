using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene("Car Racing game final");
    }

    public void Exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;

    }

}
