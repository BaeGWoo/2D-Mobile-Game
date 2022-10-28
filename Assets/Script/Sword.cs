using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
    public override void Effect()
    {
        Debug.Log("베었습니다.");
    }

    // Start is called before the first frame update
    void Start()
    {
        Effect();
    }

  
}
