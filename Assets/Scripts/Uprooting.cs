using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Uprooting : MonoBehaviour
{
    public bool readyForD;
    public bool readyForA = true;
    int counter;
    public GameObject player;
    private Animator anim;
    public TextMeshProUGUI harvest;
    public GameObject infoScreen;
    public GameObject parsnip;
    public GameObject continueBtn;


    void Start()
    {
        anim = player.GetComponent<Animator>();
        counter = 1;
        harvest.text = "press A then D to harvest yourself";
        continueBtn.SetActive(false);
    }
    
    void Update()
    {
        //counter for A and D

        if (counter <= 6)
        {
            if (Input.GetKeyDown(KeyCode.A) && readyForA && counter % 2 != 0)
            {
                readyForA = false;
                RotateSprite(0);
                counter++;
            }

            if (Input.GetKeyUp(KeyCode.A))
            { 
                readyForD = true;
            }

            if (Input.GetKeyDown(KeyCode.D) && readyForD && counter % 2 == 0)
            {
                readyForD = false;
                RotateSprite(1);
                counter++;
            }

            if (Input.GetKeyUp(KeyCode.D))
            {
                readyForA = true;
            }
        }

        else if (counter >= 6)
        {
            infoScreen.SetActive(false);
            StartCoroutine(SmallWait());
        }
    }

    //Rotate sprite
    void RotateSprite(int direction)
    {
        if (direction == 0)
        {
            parsnip.transform.eulerAngles = new Vector3(0, 0, 25);
        }

        if(direction == 1)
        {
            parsnip.transform.eulerAngles = new Vector3(0, 0, -25);
        }
    }

    IEnumerator SmallWait()
    {
        yield return new WaitForSeconds(0.5f);
        parsnip.transform.eulerAngles = new Vector3(0, 0, 0);
        anim.Play("JumpOut");
        StartCoroutine(AnotherWait());
    }

    IEnumerator AnotherWait()
    {
        yield return new WaitForSeconds(6);
        continueBtn.SetActive(true);
    }

    public void Continue()
    {
        SceneManager.LoadScene("Kitchen");
    }
}
