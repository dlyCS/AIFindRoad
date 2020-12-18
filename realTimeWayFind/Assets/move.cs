using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 1.0f;
    public Transform player;
    public Vector2 moveTraget;
    // Start is called before the first frame update
    void Start()
    {
        player = this.transform;
        moveTraget = player.position;
    }
    
    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetMouseButton(0)||Input.GetMouseButton(1))
        {

            moveTraget = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
        }

        Vector2 pos = Vector2.MoveTowards(this.player.position, moveTraget, speed * Time.deltaTime);

        this.player.position = pos;
       
    }
}
