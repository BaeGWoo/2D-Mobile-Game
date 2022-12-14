using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private float endTime = 0;
    private Vector3 direction;

    void Start()
    {
        direction = transform.localPosition;
    }

 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            StartCoroutine(Shake(0.25f, 0.25f));
        }
    }



    //amount : 흔들림의 강도
    //duration : 흔들림 지속 시간
    public IEnumerator Shake(float amount, float duration)
    {
       while(endTime<=duration)
        {
            transform.localPosition = (Vector3)Random.insideUnitCircle * amount + direction;

            duration -= Time.deltaTime;
            yield return null;
        }

        transform.localPosition = direction;
    }
}
