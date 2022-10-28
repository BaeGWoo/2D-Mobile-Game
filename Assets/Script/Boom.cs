using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : Weapon
{
    public override void Effect()
    {
        Debug.Log("폭발했습니다.");
    }

    // Start is called before the first frame update
    void Start()
    {
        Effect();
    }

   
}
