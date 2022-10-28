using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Monster
{
   public Goblin()
    {
        health = 10;
        Debug.Log("고블린의 체력 : " + health);
        Debug.Log("고블린 생성되었습니다.");
    }


    //오버라이드
    //상속 관계에서 상위 클래스에 있는 함수를 하위 클래스에서 재정의하는 기능
    override public void Attack()
    {
        //상위 클래스에 있는 Attack()함수를 호출하겠다.
        //base.Attack();
        Debug.Log("고블린 공격");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Attack();
        }
    }

}
