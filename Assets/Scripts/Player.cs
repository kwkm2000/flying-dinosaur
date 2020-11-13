using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 0.5f;
    int key = 0;

    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        GetInputKey();
        Move();
    }

    void GetInputKey()
    {
        key = 0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
        }
    }

    void Move()
    {
        this.transform.position += new Vector3(speed * Time.deltaTime * key, 0, 0);
    }

}