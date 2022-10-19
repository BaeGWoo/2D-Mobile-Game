using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigid2D;

    [SerializeField] SpriteRenderer sprite;
    [SerializeField] float speed = 1.0f;
    [SerializeField] float jumpPower = 1.0f;

    //private Vector2 direction;

    private void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    public void Slip()
    {
        rigid2D.velocity = Vector2.zero;
    }


    public void Move(Vector2 direction)
    {
        
        if (direction.x > 0)
        {
            sprite.flipX = false;
        }

        else if (direction.x < 0)
        {
            sprite.flipX = true;
        }

        transform.Translate
            (
                direction.x * speed * Time.deltaTime,
                0,
                transform.position.z
            );
    }


    public void Jump()
    {
        
            //ForceMode2D.Impulse : 무게를 적용할 때 사용합니다.
            rigid2D.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        

    }

   
    //유니티 2D에서는 2D Collider랑 Rigidbody 2D는 2D 충돌 함수를 사용해야 합니다.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("2D 충돌");
        if(collision.CompareTag("Portal"))
        {
            Camera.main.transform.position= new Vector3(20, 0, Camera.main.transform.position.z);
            transform.position = new Vector3(12.5f, 0, 0);

        }
    }


}
