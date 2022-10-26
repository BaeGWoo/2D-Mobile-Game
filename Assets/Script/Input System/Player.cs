using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigid2D;


    [SerializeField] int health = 100;
    [SerializeField] SpriteRenderer sprite;
    [SerializeField] float speed = 1.0f;
    [SerializeField] float jumpPower = 1.0f;
    
    
    public GameManager gameManager;

    public int value = 0;
   
    //private Vector2 direction;

    private void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }
    public void Update()
    {
        if (transform.position.y <= -10)
        {
            transform.position = Vector2.zero;
        }
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
        gameManager.Score = value++;

        Debug.Log(gameManager.Score);


        //ForceMode2D.Impulse : 무게를 적용할 때 사용합니다.
        rigid2D.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);


        //1초 동안 진동을 울리는 함수
        Handheld.Vibrate();
        

    }

   
    //유니티 2D에서는 2D Collider랑 Rigidbody 2D는 2D 충돌 함수를 사용해야 합니다.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("2D 충돌");
        if(collision.CompareTag("Portal"))
        {
            //Camera.main.transform.position= new Vector3(20, 0, Camera.main.transform.position.z);
            transform.position = new Vector3(32.5f, 0, 0);

        }

        if(collision.CompareTag("Potion"))
        {
            health += 10;

            //충돌당한 객체 삭제
            Destroy(collision.gameObject);
        }

    }


}
