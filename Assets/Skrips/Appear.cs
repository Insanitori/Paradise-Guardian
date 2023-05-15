using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    //private RecordingCanvas rec;
    public bool appear;
    private Vector3 original;
    public bool used;
    // Start is called before the first frame update
    void Start()
    {
        //rec = FindObjectOfType<RecordingCanvas>();
        appear = false;
        original = transform.position;
        used = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (appear)
        {
            transform.position = original;
            used = true;

            if (FindObjectOfType<GameManaging>().ON)
            {
                if (GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().office > 0)
                {
                    appear = false;
                    AudioSource.PlayClipAtPoint(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().fixe, FindObjectOfType<GyroCamera>().transform.position);

                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().office--;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().atOnce--;

                }
                else
                {
                    AudioSource.PlayClipAtPoint(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().nothing, FindObjectOfType<GyroCamera>().transform.position);
                }
                FindObjectOfType<GameManaging>().ON = false;
            }

            if (FindObjectOfType<GameManaging>().EN)
            {
                if (GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().exam > 0)
                {
                    appear = false;
                    AudioSource.PlayClipAtPoint(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().fixe, FindObjectOfType<GyroCamera>().transform.position);

                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().exam--;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().atOnce--;
                }
                else
                {
                    AudioSource.PlayClipAtPoint(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().nothing, FindObjectOfType<GyroCamera>().transform.position);
                }

                FindObjectOfType<GameManaging>().EN = false;
            }

            if (FindObjectOfType<GameManaging>().KN)
            {
                if (GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().kitchen > 0)
                {
                    appear = false;
                    AudioSource.PlayClipAtPoint(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().fixe, FindObjectOfType<GyroCamera>().transform.position);

                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().kitchen--;
                    GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().atOnce--;
                }
                else
                {
                    AudioSource.PlayClipAtPoint(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().nothing, FindObjectOfType<GyroCamera>().transform.position);
                }
                FindObjectOfType<GameManaging>().KN = false;
            }
        }

        if (!appear)
        {
            transform.position = new Vector3(1000, 10, 1000);
        }
    }
}
