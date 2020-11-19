using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCreater : MonoBehaviour
{
    public GameObject block;
    public GameObject AllTrans;
    public float Allspeed;
    public float timeOut; 
    private float timeElapsed;

    private int BlockValueOver;
    private int BlockValueUnder;
    public float BlockBaseY;
    public float BlockBaseX;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AllTrans.transform.position += new Vector3(-Allspeed, 0, 0);

        timeElapsed += Time.deltaTime;


        if (timeElapsed >= timeOut)
        {
            BlockValueOver = Random.Range(2, 5);

            for (int i = 0; i <= BlockValueOver; i++)
            {

                GameObject blockClone = GameObject.Instantiate(block) as GameObject;
                blockClone.transform.SetParent(AllTrans.transform, false);

                blockClone.transform.position = new Vector3(BlockBaseX, i - BlockBaseY, 0);
            }
            BlockValueUnder = Random.Range(1, 3);
            for (int j = 0; j <= BlockValueUnder; j++)
            {
                GameObject blockClone = GameObject.Instantiate(block) as GameObject;
                blockClone.transform.SetParent(AllTrans.transform, false);
                blockClone.transform.position = new Vector3(BlockBaseX, -j + BlockBaseY, 0);
            }
            timeElapsed = 0.0f;
        }

    }

}