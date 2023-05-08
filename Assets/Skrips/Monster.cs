using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monster : MonoBehaviour
{
    // Start is called before the first frame update

    private int attacktime;
    public int attackType;
    public bool begin;

    public bool die;

    private int giggles;
    private int talks;

    private Transform player;

    private Vector3 watching;
    private Vector3 atta;

    public AudioClip g1;
    public AudioClip g2;
    public AudioClip g3;
    public AudioClip g4;

    public AudioClip t1;
    public AudioClip t2;
    public AudioClip t3;
    public AudioClip t4;

    public AudioClip walking;

    void Start()
    {
        attacktime = 17;
        watching = new Vector3 (1000, 0, 1000);
        atta = new Vector3(.11f, -1.88f, 0.88f);

        transform.position = watching;

        player = FindObjectOfType<GyroCamera>().transform;

        die = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (begin)
        {
            StartCoroutine(attack());
            begin = false;

            if(die)
            {
                die = false;
                StartCoroutine(death());
            }
        }
    }

    public IEnumerator attack()
    {
        yield return new WaitForSeconds(attacktime);
        attacktime = Random.Range(23, 50);
        attackType = Random.Range(1, 2);

        if(attackType == 1)
        {
            //play giggle and you must freeze
            giggle();
        }
        else if(attackType == 2)
        {
            //play laugh and you must hide. You say hide and go to a room once you think you are safe
            talk();
        }
    }

    public IEnumerator giggle()
    {
        //play giggle noise
        giggles = Random.Range(1, 4);

        if (giggles == 1)
        {
            AudioSource.PlayClipAtPoint(g1, player.position);
        }
        else if (giggles == 2)
        {
            AudioSource.PlayClipAtPoint(g2, player.position);
        }
        else if (giggles == 3)
        {
            AudioSource.PlayClipAtPoint(g3, player.position);
        }
        else if (giggles == 4)
        {
            AudioSource.PlayClipAtPoint(g4, player.position);
        }

        yield return new WaitForSeconds(6);
        //if player is frozen. nothing happens. If not, jumpscare
        if(FindObjectOfType<CameraPlacer>().frozen == true)
        {
            yield return new WaitForSeconds(3);
            //walk away noise
            AudioSource.PlayClipAtPoint(walking, player.position);
            begin = true;
        }
        else if (FindObjectOfType<CameraPlacer>().frozen == false)
        {
            die = true;
        }
        
    }

    public IEnumerator talk()
    {
        //play talk noise
        if (talks == 1)
        {
            AudioSource.PlayClipAtPoint(t1, player.position);
        }
        else if (talks == 2)
        {
            AudioSource.PlayClipAtPoint(t2, player.position);
        }
        else if (talks == 3)
        {
            AudioSource.PlayClipAtPoint(t3, player.position);
        }
        else if (talks == 4)
        {
            AudioSource.PlayClipAtPoint(t4, player.position);
        }
        yield return new WaitForSeconds(6);
        //if player is hiding. nothing happens. If not, jumpscare
        if (FindObjectOfType<CameraPlacer>().hidden == true)
        {
            yield return new WaitForSeconds(2);
            //walk away noise
            AudioSource.PlayClipAtPoint(walking, player.position);
            begin = true;
        }
        else if (FindObjectOfType<CameraPlacer>().hidden == false)
        {
            die = true;
        }
    }

    public IEnumerator death()
    {
        //laud noise
        AudioSource.PlayClipAtPoint(walking, player.position);
        transform.position = atta;
        AudioSource.PlayClipAtPoint(t1, player.position);
        yield return new WaitForSeconds(2);
        //gameOver Screen
        SceneManager.LoadScene("Lose");
        SceneManager.LoadScene("Lose");

    }
}
