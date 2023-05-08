using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapear : MonoBehaviour
{
    public bool disappear;
    private Vector3 original;
    public bool used;

    public bool test;

    private RecordingCanvas rec;
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

            if (rec.Final == "Office Missing" || rec.Final == "office missing" || rec.Final == "office Missing" || rec.Final == "Office missing")
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
            }

            if (rec.Final == "Exam Missing" || rec.Final == "exam missing" || rec.Final == "exam Missing" || rec.Final == "Exam missing")
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
            }

            if (rec.Final == "Kitchen Missing" || rec.Final == "kitchen missing" || rec.Final == "kitchen Missing" || rec.Final == "Kitchen missing")
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
            }
        }

        if (!disappear)
        {
            transform.position = original;
        }
    }
}
