using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class Monster : MonoBehaviour
{
    [SerializeField] SpriteRenderer shape;


    //생성자
    //객체가 인스턴스 될 때 자동으로 호출되는 함수입니다.
    //외부에서 호출 할 수 있도록 public으로 선언해주어야 합니다.

    public int health = 100;
    public Monster()
    {
        Debug.Log("몬스터가 생성되었습니다.");
    }


    //가상 함수
    //하위 클래스에서 다시 정의할 멤버 함수입니다.
   virtual public void Attack()
    {
        Debug.Log("공격");
    }

}

/*
public class Goblin : Monster
{
    public Goblin()
    {
        Debug.Log("고블린 생성되었습니다.");
    }
}*/

