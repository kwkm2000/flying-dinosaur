using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCreater : MonoBehaviour
{
    //BlockCreater.cs
    public GameObject block;
    public GameObject AllTrans;
    //ブロックが右に流れていくスピード
    public float Allspeed;
    //何秒ごとにブロックがくるか
    public float timeOut; 
    private float timeElapsed;

    private int BlockValueOver;
    private int BlockValueUnder;
    //画面端にくるブロックのY座標　4.5ぐらい
    public float BlockBaseY;
    //画面端にくるブロックのX座標　10ぐらい 大きければ遠くからくるから最初の波がくるのが遅くなる。
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
            BlockValueOver = Random.Range(1, 5);

            for (int i = 0; i <= BlockValueOver; i++)
            {
                //複製
                GameObject Blockclone = GameObject.Instantiate(block) as GameObject;
                //BlockcloneをAllTransの子オブジェクトに
                Blockclone.transform.parent = AllTrans.transform;
                //位置を調整
                Blockclone.transform.position = new Vector3(BlockBaseX, i - BlockBaseY, 0);
            }
            BlockValueUnder = Random.Range(1, 2);
            for (int j = 0; j <= BlockValueUnder; j++)
            {
                GameObject Blockclone = GameObject.Instantiate(block) as GameObject;
                Blockclone.transform.parent = AllTrans.transform;
                Blockclone.transform.position = new Vector3(BlockBaseX, -j + BlockBaseY, 0);
            }
            timeElapsed = 0.0f;
        }

    }

}