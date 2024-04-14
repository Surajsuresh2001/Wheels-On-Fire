using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene("awakeScene");
    }

    public void Exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;

    }

}
