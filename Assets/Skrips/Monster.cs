using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // Start is called before the first frame update

    private int attacktime;
    public int attackType;
    public bool begin;

    private Vector3 watching;
    private Vector3 atta;

    void Start()
    {
        attacktime = 17;
        watching = new Vector3 (1000, 0, 1000);
        atta = new Vector3(.11f, -1.88f, 0.88f);

        transform.position = watching;
    }

    // Update is called once per frame
    void Update()
    {
        if (begin)
        {
            StartCoroutine(attack());
            begin = false;
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
            laugh();
        }
    }

    public IEnumerator giggle()
    {
        //play giggle noise
        yield return new WaitForSeconds(6);
        //if player is frozen. nothing happens. If not, jumpscare
        if(FindObjectOfType<CameraPlacer>().frozen == true)
        {
            yield return new WaitForSeconds(3);
            //walk away noise
            begin = true;
        }
        else if (FindObjectOfType<CameraPlacer>().frozen == false)
        {
            //laud noise
            transform.position = atta;
            //gameOver
        }
        
    }

    public IEnumerator laugh()
    {
        //play laugh noise
        yield return new WaitForSeconds(6);
        //if player is hiding. nothing happens. If not, jumpscare
        if (FindObjectOfType<CameraPlacer>().hidden == true)
        {
            yield return new WaitForSeconds(3);
            //walk away noise
            begin = true;
        }
        else if (FindObjectOfType<CameraPlacer>().hidden == false)
        {
            //laud noise
            transform.position = atta;
            //gameOver Screen
        }
    }
}
