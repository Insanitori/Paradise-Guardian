using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlacer : MonoBehaviour
{
    private RecordingCanvas rec;

    public Transform OfficeCam;
    public Transform KitchenCam;
    public Transform ExamCam;
    public Transform hiddingCam;

    private bool start;

    public bool hidden;
    public bool frozen;
    private bool clipDone;

    public bool test;

    public AudioClip tut1;
    public AudioClip tut2;

    public AudioClip breathing;
    // Start is called before the first frame update
    void Start()
    {
        frozen = false;
        hidden = false;
        clipDone = false;
        start = false;

        test = false;
        rec = FindObjectOfType<RecordingCanvas>();
        transform.position = OfficeCam.position;

        StartCoroutine(tutorial());
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            if (rec.Final == "Exam" || rec.Final == "exam")
            {
                transform.position = ExamCam.position;
                hidden = false;
                frozen = false;
            }
            else if (rec.Final == "Office" || rec.Final == "office")
            {
                transform.position = OfficeCam.position;
                hidden = false;
                frozen = false;
            }
            else if (rec.Final == "Kitchen" || rec.Final == "kitchen")
            {
                transform.position = KitchenCam.position;
                hidden = false;
                frozen = false;
            }

            if (rec.Final == "Freeze" || rec.Final == "freeze")
            {
                frozen = true;
            }

            if (rec.Final == "Hide" || rec.Final == "hide")
            {
                hidden = true;
                transform.position = hiddingCam.position;
                AudioSource.PlayClipAtPoint(breathing, transform.position);
            }
        }

        if (rec.Final == "yes" || rec.Final == "Yes"*/test && clipDone)
        {
            AudioSource.PlayClipAtPoint(tut2, transform.position);
            start = true;
            GameObject.Find("GameeeMAHER").GetComponent<GameManaging>().StartGame = true;
            FindObjectOfType<Monster>().begin = true;
            clipDone = false;
        }
    }

    public IEnumerator tutorial()
    {
        /*yield return new WaitForSeconds(2);
        AudioSource.PlayClipAtPoint(tut1, transform.position);
        yield return new WaitForSeconds(205);*/
        yield return new WaitForSeconds(3);
        clipDone = true;
    }
}
