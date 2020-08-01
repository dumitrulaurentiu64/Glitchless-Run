using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyAnimation : MonoBehaviour
{
    //static bool alreadySpawned = true;
    public AudioSource sourceCoin;

    public Text score, t;

    public GameObject character, coin, bomb, platform;
    float a = 0f, k = 30f, z = -10f;
    int x;
    public float time = 0f;

    void Start()
    {
        sourceCoin = character.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    { 

        if (other.gameObject.name == "coin1" || other.gameObject.name == "coin1(Clone)" ||
            other.gameObject.name == "coin2" || other.gameObject.name == "coin2(Clone)" ||
            other.gameObject.name == "coin3" || other.gameObject.name == "coin3(Clone)")
        {
            sourceCoin.Play();

            a = (int)(a + 1);

            score.text = string.Format("{0}", (int)a);

            if (a >= 1)
            {
                if ((Random.Range(0, 2) == 0 ? 0 : 1) == 0)
                {
                    x = Random.Range(0, 3);
                    if (x == 0)
                    {
                        Instantiate(coin, new Vector3(Random.Range(-4.9f, -5.1f), 0f, z + k), Quaternion.identity);
                        k = k + 4;
                        Instantiate(coin, new Vector3(Random.Range(-4.9f, -5.1f), 0f, z + k), Quaternion.identity);
                        k = k + 4;
                        Instantiate(coin, new Vector3(Random.Range(-4.9f, -5.1f), 0f, z + k), Quaternion.identity);
                        k = k + 4;
                        Instantiate(coin, new Vector3(Random.Range(-4.9f, -5.1f), 0f, z + k), Quaternion.identity);
                        k = k + 20;
                    }
                    else if (x == 1)
                    {

                        Instantiate(coin, new Vector3(Random.Range(-0.1f, 0.1f), 0f, z + k), Quaternion.identity);
                        k = k + 4;
                        Instantiate(coin, new Vector3(Random.Range(-0.1f, 0.1f), 0f, z + k), Quaternion.identity);
                        k = k + 4;
                        Instantiate(coin, new Vector3(Random.Range(-0.1f, 0.1f), 0f, z + k), Quaternion.identity);
                        k = k + 4;
                        Instantiate(coin, new Vector3(Random.Range(-0.1f, 0.1f), 0f, z + k), Quaternion.identity);
                        k = k + 20;
                    }
                    else if (x == 2)
                    {
                        Instantiate(coin, new Vector3(Random.Range(4.9f, 5.1f), 0f, z + k), Quaternion.identity);
                        k = k + 4;
                        Instantiate(coin, new Vector3(Random.Range(4.9f, 5.1f), 0f, z + k), Quaternion.identity);
                        k = k + 4;
                        Instantiate(coin, new Vector3(Random.Range(-0.1f, 0.1f), 0f, z + k), Quaternion.identity);
                        k = k + 4;
                        Instantiate(coin, new Vector3(Random.Range(-0.1f, 0.1f), 0f, z + k), Quaternion.identity);
                        k = k + 20;
                    }
                }
                else
                {
                    x = Random.Range(0, 3);
                    if (x == 0)
                    {
                        if (k > 100)
                            Instantiate(platform, new Vector3(Random.Range(-4.9f, -5.1f), 2f, z + k), Quaternion.identity);

                        Instantiate(coin, new Vector3(Random.Range(-4.9f, -5.1f), 4f, z + k), Quaternion.identity);
                        k = k + 4;
                        Instantiate(coin, new Vector3(Random.Range(-4.9f, -5.1f), 4f, z + k), Quaternion.identity);
                        k = k + 4;
                        Instantiate(coin, new Vector3(Random.Range(-0.1f, 0.1f), 0f, z + k), Quaternion.identity);
                        k = k + 4;
                        Instantiate(coin, new Vector3(Random.Range(-0.1f, 0.1f), 0f, z + k), Quaternion.identity);
                        k = k + 20;
                    }
                    else if (x == 1)
                    {

                        if ( k > 100 )
                            Instantiate(platform, new Vector3(Random.Range(-0.1f, 0.1f), 2f, z + k), Quaternion.identity);

                        Instantiate(coin, new Vector3(Random.Range(-0.1f, 0.1f), 4f, z + k), Quaternion.identity);
                        k = k + 4;
                        Instantiate(coin, new Vector3(Random.Range(-0.1f, 0.1f), 4f, z + k), Quaternion.identity);
                        k = k + 4;
                        Instantiate(coin, new Vector3(Random.Range(-0.1f, 0.1f), 0f, z + k), Quaternion.identity);
                        k = k + 4;
                        Instantiate(coin, new Vector3(Random.Range(-0.1f, 0.1f), 0f, z + k), Quaternion.identity);
                        k = k + 20;
                    }
                    else if (x == 2)
                    {
                        if (k > 100)
                            Instantiate(platform, new Vector3(Random.Range(4.9f,  5.1f), 2f, z + k), Quaternion.identity);

                        Instantiate(coin, new Vector3(Random.Range(4.9f, 5.1f), 4f, z + k), Quaternion.identity);
                        k = k + 4;
                        Instantiate(coin, new Vector3(Random.Range(4.9f, 5.1f), 4f, z + k), Quaternion.identity);
                        k = k + 4;
                        Instantiate(coin, new Vector3(Random.Range(-0.1f, 0.1f), 0f, z + k), Quaternion.identity);
                        k = k + 4;
                        Instantiate(coin, new Vector3(Random.Range(-0.1f, 0.1f), 0f, z + k), Quaternion.identity);
                        k = k + 20;
                    }
                }
            }
        }



        if (other.gameObject.name == "BombBall" || other.gameObject.name == "BombBall(Clone)")
        {
            SceneManager.LoadScene("YouDied");
        }

        if (a >= 1)
        {
            if ((Random.Range(0, 2) == 0 ? 0 : 1) == 0)
            {
                x = Random.Range(0, 3);
                if (x == 0)
                {
                    Instantiate(bomb, new Vector3(Random.Range(-4.9f, -5.1f), 0f, z + k), Quaternion.identity);
                    k = k + 10;

                }
                else if (x == 1)
                {
                    Instantiate(bomb, new Vector3(Random.Range(-0.1f, 0.1f), 0f, z + k), Quaternion.identity);
                    k = k + 10;

                }
                else if (x == 2)
                {
                    Instantiate(bomb, new Vector3(Random.Range(4.9f, 5.1f), 0f, z + k), Quaternion.identity);
                    k = k + 10;

                }
            }
            else
            {
                x = Random.Range(0, 3);
                if (x == 0)
                {
                    Instantiate(bomb, new Vector3(Random.Range(-4.9f, -5.1f), 2.5f, z + k), Quaternion.identity);
                    k = k + 10;

                }
                else if (x == 1)
                {
                    Instantiate(bomb, new Vector3(Random.Range(-0.1f, 0.1f), 2.5f, z + k), Quaternion.identity);
                    k = k + 10;

                }
                else if (x == 2)
                {
                    Instantiate(bomb, new Vector3(Random.Range(4.9f, 5.1f), 2.5f, z + k), Quaternion.identity);
                    k = k + 10;

                }
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        /*if (transform.localPosition.z > 50 && alreadySpawned)
        {
            Instantiate(coin, new Vector3(Random.Range(-0.1f, 0.1f), 0f, z + k), Quaternion.identity);
            Instantiate(coin, new Vector3(Random.Range(4.9f, 5.1f), 0f, z + k), Quaternion.identity);
            Instantiate(coin, new Vector3(Random.Range(-4.9f, -5.1f), 4f, z + k), Quaternion.identity);
            k = k + 4;
            Instantiate(coin, new Vector3(Random.Range(-0.1f, 0.1f), 0f, z + k), Quaternion.identity);
            Instantiate(coin, new Vector3(Random.Range(4.9f, 5.1f), 0f, z + k), Quaternion.identity);
            Instantiate(coin, new Vector3(Random.Range(-4.9f, -5.1f), 0f, z + k), Quaternion.identity);
            k = k + 4;
            Instantiate(coin, new Vector3(Random.Range(-0.1f, 0.1f), 0f, z + k), Quaternion.identity);
            Instantiate(coin, new Vector3(Random.Range(4.9f, 5.1f), 0f, z + k), Quaternion.identity);
            Instantiate(coin, new Vector3(Random.Range(-4.9f, -5.1f), 0f, z + k), Quaternion.identity);
            k = k + 4;
            Instantiate(coin, new Vector3(Random.Range(-0.1f, 0.1f), 0f, z + k), Quaternion.identity);
            Instantiate(coin, new Vector3(Random.Range(4.9f, 5.1f), 0f, z + k), Quaternion.identity);
            Instantiate(coin, new Vector3(Random.Range(-4.9f, -5.1f), 0f, z + k), Quaternion.identity);
            k = k + 20;
            alreadySpawned = false;
        }*/

        Animation animatie = character.GetComponent<Animation>();

        if (Input.GetKey("space"))
        {
            animatie["Jump_2"].speed = 0.5f;
            animatie.Play("Jump_2");
            if (transform.localPosition.y < 4)
                character.transform.position = character.transform.position + new Vector3(0f, 0.075f, 0f);
        }
        else
            animatie.Play("Running");

        time = time + Time.deltaTime;

        t.text = string.Format("{0}", time + "seconds");
    }
}
