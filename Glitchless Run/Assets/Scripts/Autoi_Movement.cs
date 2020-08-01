using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Autoi_Movement : MonoBehaviour
{
    float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.z % 100 == 0)
            speed = speed++;
        transform.Translate(0, 0, Time.deltaTime * speed);
    }
}
