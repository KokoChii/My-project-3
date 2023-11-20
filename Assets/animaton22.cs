using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float speed;
    private void Awake()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Input.GetAxis("Horizontal");
        float horizontal = Input.GetAxis("Horizontal");

        Input.GetAxis("Vertical");
        float vertical = Input.GetAxis("Vertical");


        Vector2 dir = new Vector2(horizontal, vertical);
        dir = dir.normalized;

        Debug.DrawRay(transform.position, dir * 5);
        //rb.MovePosition(transform.position + speed * Time.deltaTime * dir);

        playerRB.velocity = dir * speed ;

        if (dir.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (dir.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

    }
}

