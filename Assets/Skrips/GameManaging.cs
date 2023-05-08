using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class GameManaging : MonoBehaviour
{
    public TextMeshProUGUI Timer;

    public bool StartGame;
    private bool startOdd;
    private float timeRemaining;

    public int oddity;
    private bool setoddEven;

    public int atOnce;

    public bool missing;
    public bool apparing;
    public bool materialchanging;
    public bool swapping;

    public int office;
    public int kitchen;
    public int exam;


    // Start is called before the first frame update
    void Start()
    {
        StartGame = false;
        setoddEven = false;
        startOdd = true;
        timeRemaining = 300;
        Timer.text = "???";

        oddity = 21;
        atOnce = 0;

        missing = false;
        apparing = false;
        materialchanging = false;
        swapping = false;
        office = 0;
        kitchen = 0;
        exam = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(StartGame)
        {
            if(setoddEven) 
            {
                StartCoroutine(oddbity());
            }

            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("You have Won!");
                timeRemaining = 0;
                StartGame = false;
            }

            Timer.text = timeRemaining.ToString();

            if (startOdd)
            {
                RandomOddity();
            }

            if(atOnce >= 5)
            {
                Debug.Log("You fucked, Boi");
            }
        }
    }

    public IEnumerator oddbity()
    {
        setoddEven = false;
        yield return new WaitForSeconds(20);
        oddity = Random.Range(1, 21);
        startOdd = true;
    }

    void RandomOddity()
    {
        startOdd = false;
        setoddEven = true;

        switch (oddity)
        {
            case 1:
                //Office Cupboard Swap
                if (GameObject.Find("CupboardSwap").GetComponent<Swap>().used == false)
                {
                    office++;
                    GameObject.Find("CupboardSwap").GetComponent<Swap>().disappear = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }

                break; 
            case 2:
                //Office Antlers Missing
                if (GameObject.Find("AntlerDis").GetComponent<Dissapear>().used == false)
                {
                    office++;
                    GameObject.Find("AntlerDis").GetComponent<Dissapear>().disappear = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            case 3:
                //Office Door Swap
                if (GameObject.Find("Doorswapps").GetComponent<Swap>().used == false)
                {
                    office++;
                    GameObject.Find("Doorswapps").GetComponent<Swap>().disappear = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            case 4:
                //Office Floor Color
                if (GameObject.Find("FloorOffCol").GetComponent<MaterialSwap>().used == false)
                {
                    office++;
                    GameObject.Find("FloorOffCol").GetComponent<MaterialSwap>().swapMesh = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            case 5:
                //Office Table Color
                if (GameObject.Find("TableColor").GetComponent<MaterialSwap>().used == false)
                {
                    office++;
                    GameObject.Find("TableColor").GetComponent<MaterialSwap>().swapMesh = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            case 6:
                //Office Statue New
                if (GameObject.Find("StatueNew").GetComponent<Appear>().used == false)
                {
                    office++;
                    GameObject.Find("StatueNew").GetComponent<Appear>().appear = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            case 7:
                //Office Heater New
                if (GameObject.Find("Heett").GetComponent<Appear>().used == false)
                {
                    office++;
                    GameObject.Find("Heett").GetComponent<Appear>().appear = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            case 8:
                // Exam Wall Color
                if (GameObject.Find("Surgerywaller").GetComponent<MaterialSwap>().used == false)
                {
                    exam++;
                    GameObject.Find("Surgerywaller").GetComponent<MaterialSwap>().swapMesh = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            case 9:
                //Exam SurgeryLamp Missing
                if (GameObject.Find("SurgeryLampbye").GetComponent<Dissapear>().used == false)
                {
                    exam++;
                    GameObject.Find("SurgeryLampbye").GetComponent<Dissapear>().disappear = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            case 10:
                //Exam Toilet New
                if (GameObject.Find("ToiletPopNew").GetComponent<Appear>().used == false)
                {
                    exam++;
                    GameObject.Find("ToiletPopNew").GetComponent<Appear>().appear = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break; 
            case 11:
                //Exam surgtable Swap
                if (GameObject.Find("SurgeryTablebfb").GetComponent<Swap>().used == false)
                {
                    exam++;
                    GameObject.Find("SurgeryTablebfb").GetComponent<Swap>().disappear = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            case 12:
                //Exam Heater Missing
                if (GameObject.Find("Hees").GetComponent<Dissapear>().used == false)
                {
                    exam++;
                    GameObject.Find("Hees").GetComponent<Dissapear>().disappear = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            case 13:
                //Exam MedRack Missing
                if (GameObject.Find("MedRackBoobs").GetComponent<Dissapear>().used == false)
                {
                    exam++;
                    GameObject.Find("MedRackBoobs").GetComponent<Dissapear>().disappear = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            case 14:
                //Exam bed swap
                if (GameObject.Find("SurgeelBad").GetComponent<Swap>().used == false)
                {
                    exam++;
                    GameObject.Find("SurgeelBad").GetComponent<Swap>().disappear = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            case 15:
                //Kitchen Stairs New
                if (GameObject.Find("Stairs_dasda").GetComponent<Appear>().used == false)
                {
                    kitchen++;
                    GameObject.Find("Stairs_dasda").GetComponent<Appear>().appear = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            case 16:
                //kitchen Chandelier new
                if (GameObject.Find("Chandeliergf").GetComponent<Appear>().used == false)
                {
                    kitchen++;
                    GameObject.Find("Chandeliergf").GetComponent<Appear>().appear = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            case 17:
                //Kitchen Tv Swap
                if (GameObject.Find("Tellyss").GetComponent<Swap>().used == false)
                {
                    kitchen++;
                    GameObject.Find("Tellyss").GetComponent<Swap>().disappear = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            case 18:
                //Kitchen window missing
                if (GameObject.Find("Windowssdsd").GetComponent<Dissapear>().used == false)
                {
                    kitchen++;
                    GameObject.Find("Windowssdsd").GetComponent<Dissapear>().disappear = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            case 19:
                //kitchen fridge color
                if (GameObject.Find("Fridge_Caspopo").GetComponent<MaterialSwap>().used == false)
                {
                    kitchen++;
                    GameObject.Find("Fridge_Caspopo").GetComponent<MaterialSwap>().swapMesh = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            case 20:
                //kitchen kitchenshelf color
                if (GameObject.Find("KitchenShsdhhhelf").GetComponent<MaterialSwap>().used == false)
                {
                    kitchen++;
                    GameObject.Find("KitchenShsdhhhelf").GetComponent<MaterialSwap>().swapMesh = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            case 21:
                //Kitchen chair swap
                if (GameObject.Find("dfChair").GetComponent<Swap>().used == false)
                {
                    kitchen++;
                    GameObject.Find("dfChair").GetComponent<Swap>().disappear = true;
                    atOnce++;
                }
                else
                {
                    oddity = Random.Range(1, 21);
                    RandomOddity();
                }
                break;
            default:
                //huh
                break;
        }
    }
}
