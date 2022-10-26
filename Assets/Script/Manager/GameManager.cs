using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public enum state
    {
        Idle,       //게임 대기
        Progress,   //게임 진행
        End         //게임 종료

    }

    private state currentState;

    //프로퍼티
    public state State
    {
        get { return currentState; }
        set { currentState = value; }
    }

    private int score=0;


    //프로퍼티
    //다른 클래스에서 해당 변수의 값을 변경시킬 때 사용합니다.
    public int Score
    {
        //해당 변수를 출력해주는 기능
        get { return score; }

        //해당 변수에 값을 넣어주는 기능
        set
        {
            score = value;

            if (score >= 100)
                score = 100;

        }
    }


    private void Start()
    {
        State = state.Idle;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            State = state.Idle;
            StateMachine();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            State = state.Progress;
            StateMachine();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            State = state.End;
            StateMachine();
        }
    }

    public void StateMachine()
    {
        switch (State)
        {
            case state.Idle:
                Time.timeScale = 0;
                //Debug.Log("게임 대기 상태");
                break;

            case state.Progress:
                Time.timeScale = 1;
                //Debug.Log("게임 진행 상태");
                break;

            case state.End:
                Time.timeScale = 0;
                //Debug.Log("게임 종료 상태");
                break;

        }
    }
}
