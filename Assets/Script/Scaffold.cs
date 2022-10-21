using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaffold : MonoBehaviour
{

  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Time.time =게임 실행시간을 누적합니다.
        //x츅으로 -9.999까지 이동하다가 다시 0.0001로 이동합니다.
        
        transform.position =
           new Vector2
           (
            Mathf.PingPong(Time.time, 5),
            transform.position.y
            );
    }
}
