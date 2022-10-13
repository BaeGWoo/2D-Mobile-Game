using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] SpriteRenderer sprite;
    [SerializeField] float speed = 1.0f;

    //private Vector2 direction;


    
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if(x>0)
        {
            sprite.flipX = false;
        }

        else if(x<0)
        {
            sprite.flipX = true;
        }

        transform.Translate(x * speed * Time.deltaTime,y*speed*Time.deltaTime,transform.position.z);
    }


    //유니티 2D에서는 2D Collider랑 Rigidbody 2D는 2D 충돌 함수를 사용해야 합니다.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("2D 충돌");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("2D 충돌중");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("2D 충돌 벗어남");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("2D 충돌 Collision");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("2D 충돌중 Collision");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("2D 충돌 벗어남 Collision");
    }

}
