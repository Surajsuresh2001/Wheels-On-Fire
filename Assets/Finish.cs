using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            SceneManager.LoadScene("Gameover");
        }
        
    }

    
}
