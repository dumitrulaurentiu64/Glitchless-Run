using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deschide_inchide : MonoBehaviour
{
    // Start is called before the first frame update
    public void deschide()
    {
        SceneManager.LoadScene("runScene");
    }

    // Update is called once per frame
    public void inchide()
    {
        Application.Quit();
    }
}
