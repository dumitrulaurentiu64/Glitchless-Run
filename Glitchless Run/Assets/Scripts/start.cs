using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class start : MonoBehaviour
{
    string cale = "Assets/Saves/scor.txt";
    public Text sc_t;
    // Start is called before the first frame update
    void Start()
    {
        sc_t.text = Value.t;

        StreamWriter f = new StreamWriter(cale, true);

        f.WriteLine(sc_t.text);

        f.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
