using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailManager : MonoBehaviour
{
    public GameObject[] boxes = new GameObject[43];
    public GameObject[] rail0 = new GameObject[3];
    public GameObject[] rail1 = new GameObject[8];
    public GameObject[] rail2 = new GameObject[8];
    public GameObject[] rail3 = new GameObject[8];
    public GameObject[] rail4 = new GameObject[8];
    public GameObject[] rail5 = new GameObject[8];
    public GameObject brokenBox1;
    public GameObject brokenBox2;
    public GameObject brokenBox3;

    [Range (-2, 43)]
    public int boxPos;
    [Range (-2, 2)]
    public int boxPosRail0;
    [Range (-2, 7)]
    public int boxPosRail1;
    [Range (-2, 7)]
    public int boxPosRail2;
    [Range(-2, 7)]
    public int boxPosRail3;
    [Range(-2, 7)]
    public int boxPosRail4;
    [Range(-2, 7)]
    public int boxPosRail5;
    public float timeBtwBox;
    private PlayerControler playerCo;

    private void Awake()
    {
        for (int i = 0; i < boxes.Length; i++)
        {
            boxes[i].SetActive(false);
        }
        brokenBox1.SetActive(false);
        brokenBox2.SetActive(false);
        brokenBox3.SetActive(false);
        playerCo = GetComponent<PlayerControler>();

    }
    void Start()
    {
        StartCoroutine(MoveBoxRail0());
    }

    void Update()
    {

    }
    private IEnumerator MoveBoxRail0()
    {
        if (boxPosRail0 < rail0.Length)
        {
            for (int i = 0; i < rail0.Length; i++)
            {
                yield return new WaitForSeconds(timeBtwBox);
                boxPosRail0++;

                for (int b = 0; b < rail0.Length; b++)
                {
                    if (boxPosRail0 == b)
                    {
                        rail0[b].SetActive(true);
                    }
                    else rail0[b].SetActive(false);

                }
                if (boxPosRail0 == 2)
                {
                    boxPosRail0 = -1;
                }
            }
            if (playerCo.marioPos == 0)
            {
                StartCoroutine(MoveBoxRail1());
                yield return new WaitForSeconds(timeBtwBox);
                rail0[2].SetActive(false);
            }
            else
            {
                yield return new WaitForSeconds(timeBtwBox);
                rail0[2].SetActive(false);
                brokenBox1.SetActive(true);
                yield return new WaitForSeconds(timeBtwBox);
                brokenBox1.SetActive(false);
            }
            yield return new WaitForSeconds(Random.Range(5f, 10f));
            StartCoroutine(MoveBoxRail0());
        }
    }

    private IEnumerator MoveBoxRail1()
    {
        if (boxPosRail1 < rail1.Length)
        {
            for (int i = 0; i < rail1.Length; i++)
            {
                yield return new WaitForSeconds(timeBtwBox);
                boxPosRail1++;

                for (int b = 0; b < rail1.Length; b++)
                {
                    if (boxPosRail1 == b)
                    {
                        rail1[b].SetActive(true);
                    }
                    else rail1[b].SetActive(false);

                }
                if (boxPosRail1 == 7)
                {
                    boxPosRail1 = -1;
                }
            }
            if (playerCo.luigiPos == 0)
            {
                StartCoroutine(MoveBoxRail2());
                yield return new WaitForSeconds(timeBtwBox);
                rail1[7].SetActive(false);
            }
            else
            {
                yield return new WaitForSeconds(timeBtwBox);
            rail1[7].SetActive(false);
            brokenBox3.SetActive(true);
            yield return new WaitForSeconds(timeBtwBox);
            brokenBox3.SetActive(false);
            }
        }
    }
    private IEnumerator MoveBoxRail2()
    {
        if (boxPosRail2 < rail2.Length)
        {
            for(int i = 0; i < rail2.Length; i++)
            {
                boxPosRail2++;
                yield return new WaitForSeconds(timeBtwBox);

                for (int b = 0; b < rail2.Length; b++)
                {
                    if (boxPosRail2 == b)
                    {
                        rail2[b].SetActive(true);
                    }
                    else
                        rail2[b].SetActive(false);
                }
            }
            if (boxPosRail2 == 7)
            {
                boxPosRail2 = -1;
            }
            if (playerCo.marioPos == 1)
            {
                StartCoroutine(MoveBoxRail3());
            yield return new WaitForSeconds(timeBtwBox);
            rail2[7].SetActive(false);
            }
        }
    }
    private IEnumerator MoveBoxRail3()
    {
        if (boxPosRail3 < rail3.Length)
        {
            for (int i = 0; i < rail3.Length; i++)
            {
                boxPosRail3++;
                yield return new WaitForSeconds(timeBtwBox);

                for (int b = 0; b < rail3.Length; b++)
                {
                    if (boxPosRail3 == b)
                    {
                        rail3[b].SetActive(true);
                    }
                    else
                        rail3[b].SetActive(false);
                }
            }
            if (boxPosRail3 == 7)
            {
                boxPosRail3 = -1;
            }
            if (playerCo.luigiPos == 1)
            {
                StartCoroutine(MoveBoxRail4());
                yield return new WaitForSeconds(timeBtwBox);
                rail3[7].SetActive(false);
            }
        }
    }

    private IEnumerator MoveBoxRail4()
    {
        if (boxPosRail4 < rail4.Length)
        {
            for (int i = 0; i < rail4.Length; i++)
            {
                boxPosRail4++;
                yield return new WaitForSeconds(timeBtwBox);

                for (int b = 0; b < rail4.Length; b++)
                {
                    if (boxPosRail4 == b)
                    {
                        rail4[b].SetActive(true);
                    }
                    else
                        rail4[b].SetActive(false);
                }
            }
            if (boxPosRail4 == 7)
            {
                boxPosRail4 = -1;
            }
            if (playerCo.marioPos == 2)
            {
            StartCoroutine(MoveBoxRail5());
            yield return new WaitForSeconds(timeBtwBox);
            rail4[7].SetActive(false);
            }
        }
    }

    private IEnumerator MoveBoxRail5()
    {
        if (boxPosRail5 < rail5.Length)
        {
            for (int i = 0; i < rail5.Length; i++)
            {
                boxPosRail5++;
                yield return new WaitForSeconds(timeBtwBox);

                for (int b = 0; b < rail5.Length; b++)
                {
                    if (boxPosRail5 == b)
                    {
                        rail5[b].SetActive(true);
                    }
                    else
                        rail5[b].SetActive(false);
                }
            }
            if (boxPosRail5 == 7)
            {
                boxPosRail5 = -1;
            }
            if (playerCo.luigiPos == 2)
            {
            yield return new WaitForSeconds(timeBtwBox);
            rail5[7].SetActive(false);
            }

            yield return new WaitForSeconds(Random.Range(1f, 5f));
        }
    }

}
