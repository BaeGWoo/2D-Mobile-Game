using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baron :Monster
{
   public Baron()
    {
        health = 100;
    }

    public void Start()
    {
        Debug.Log("바론의 체력은 : " + health);
    }
}
