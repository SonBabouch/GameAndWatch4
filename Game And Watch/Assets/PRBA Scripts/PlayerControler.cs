using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public GameObject[] mario = new GameObject[3];
    public GameObject[] luigi = new GameObject[3];
    [Range(0, 2)]
    public int marioPos = 0;
    [Range(0, 2)]
    public int luigiPos = 0;

    void Start()
    {

        for (int i = 1; i < mario.Length; i++)
        {
            mario[i].SetActive(false);
        }

        for (int i = 1; i < luigi.Length; i++)
        {
            luigi[i].SetActive(false);
        }
    }


    void Update()
    {
        MoveMario();
        MoveLuigi();
    }

    public void MoveMario()
    {
        //Mario
        if (Input.GetKeyDown(KeyCode.UpArrow) && marioPos < 2)
        {
            marioPos++;
            Debug.Log(marioPos);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && marioPos > 0)
        {
            marioPos--;
            Debug.Log(marioPos);
        }
        for (int i = 0; i < mario.Length; i++)
        {
            if (marioPos == i)
            {
                mario[i].SetActive(true);
            }
            else
                mario[i].SetActive(false);
        }
    }
    public void MoveLuigi()
    {
        //Luigi
        if (Input.GetKeyDown(KeyCode.Z) && luigiPos < 2)
        {
            luigiPos++;
            //Debug.Log(luigiPos);
        }
        if (Input.GetKeyDown(KeyCode.S) && luigiPos > 0)
        {
            luigiPos--;
            //Debug.Log(luigiPos);
        }
        for (int i = 0; i < luigi.Length; i++)
        {
            if (luigiPos == i)
            {
                luigi[i].SetActive(true);
            }
            else
                luigi[i].SetActive(false);
        }
    }
}