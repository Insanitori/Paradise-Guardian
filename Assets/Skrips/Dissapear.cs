using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapear : MonoBehaviour
{
    public bool disappear;
    private Vector3 original;
    public bool used;

    public bool test;

    //private RecordingCanvas rec;
    // Start is called before the first frame update
    void Start()
    {
        disappear = false;
        original = transform.position;
        used = false;

        test = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (disappear)
        {
            transform.position = new Vector3(1000, 10, 1000);
            disappear = true;
            used = true;

            if (FindObjectOfType<GameManaging>().OD)
            {
                if (GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().office > 0)
                {
                    disappear = false;
                    AudioSource.PlayClipAtPoint(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().fixe, FindObjectOfType<GyroCamera>().transform.position);

                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().office--;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().atOnce--;

                }
                else
                {
                    AudioSource.PlayClipAtPoint(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().nothing, FindObjectOfType<GyroCamera>().transform.position);
                }
                FindObjectOfType<GameManaging>().OD = false;
            }

            if (FindObjectOfType<GameManaging>().ED)
            {
                if (GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().exam > 0)
                {
                    disappear = false;
                    AudioSource.PlayClipAtPoint(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().fixe, FindObjectOfType<GyroCamera>().transform.position);

                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().exam--;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().atOnce--;
                }
                else
                {
                    AudioSource.PlayClipAtPoint(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().nothing, FindObjectOfType<GyroCamera>().transform.position);
                }
                FindObjectOfType<GameManaging>().ED = false;
            }

            if (FindObjectOfType<GameManaging>().KD)
            {
                if (GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().kitchen > 0)
                {
                    disappear = false;
                    AudioSource.PlayClipAtPoint(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().fixe, FindObjectOfType<GyroCamera>().transform.position);

                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().kitchen--;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().atOnce--;
                }
                else
                {
                    AudioSource.PlayClipAtPoint(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().nothing, FindObjectOfType<GyroCamera>().transform.position);
                }
                FindObjectOfType<GameManaging>().KD = false;
            }
        }

        if (!disappear)
        {
            transform.position = original;
        }
    }
}
