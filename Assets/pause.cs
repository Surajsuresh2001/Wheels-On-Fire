using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
    bool pauseval=true;
    public Text t1;

     public void Pause_resume()
    {
    
            if (pauseval)
            {
        Time.timeScale = 0;
        pauseval = false;
        t1.text = "Resume";
    }
    else
    {
        Time.timeScale = 1;
        pauseval = true;
        t1.text = "Pause";
    }
}
}
