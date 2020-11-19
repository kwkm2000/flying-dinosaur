using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float runForce = 30.0f;
    public float jumpForce;

    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {


        //float horizontalKey = Input.GetAxis("Horizontal");
        //float xSpeed = 0.0f;

        // クリックで飛ぶ
        if (Input.GetMouseButtonUp(0))
        {
            this.rb.AddForce(new Vector2(0, jumpForce));
        }

        //if (horizontalKey > 0)
        //{
        //    transform.localScale = new Vector3(1, 1, 1);
        //    xSpeed = speed;
        //}
        //else if (horizontalKey < 0)
        //{
        //    transform.localScale = new Vector3(-1, 1, 1);
        //    xSpeed = -speed;
        //} else
        //{
        //    xSpeed = 0.0f;
        //}
        //rb.velocity = new Vector2(xSpeed, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var collisionName = collision.gameObject.name;
        var gameOverObjectName = "Thorn";
        var sceneName = "GameOver";

        if (collisionName == gameOverObjectName)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
    }

}