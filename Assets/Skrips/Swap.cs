using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap : MonoBehaviour
{
    public bool disappear;
    private Vector3 originalPos;
    private Quaternion originalRot;
    public bool used;

    public GameObject other;

    

    //private RecordingCanvas rec;
    // Start is called before the first frame update
    void Start()
    {
        //rec = FindObjectOfType<RecordingCanvas>();
        disappear = false;
        originalPos = transform.position;
        originalRot = transform.rotation;
        used = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (disappear)
        {
            transform.position = new Vector3(1000, 10, 1000);
            other.transform.position = originalPos;
            other.transform.rotation = originalRot;

            used = true;

            if (FindObjectOfType<GameManaging>().OC)
            {
                if(GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().office > 0)
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
                FindObjectOfType<GameManaging>().OC = false;
            }

            if (FindObjectOfType<GameManaging>().EC)
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
                FindObjectOfType<GameManaging>() .EC = false;
            }

            if (FindObjectOfType<GameManaging>().KC)
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
                FindObjectOfType<GameManaging>().KC = false;
            }
        }

        if (!disappear)
        {
            other.transform.position = new Vector3(1000, 10, 1000);
            transform.position = originalPos;
        }
    }
}
