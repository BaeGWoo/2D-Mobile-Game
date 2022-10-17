using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.SimpleAndroidNotifications;
using System;
using System.Text;


public class Notification : MonoBehaviour
{

    // 알림 제목
    private string title = "알림";

    //알림 내용
    private string content = "앱에 접속해서 게임을 시작해주세요.";
    
    void Start()

    {
        OnApplicationPause(true);
    }

    private void OnApplicationPause(bool pause)
    {
        //안드로이드일 때 실행되는 코드
#if UNITY_ANDROID

        NotificationManager.CancelAll();

        if(pause)
        {
            //앱을 잠시 쉴 때 일정 시간 후에 알림하는 기능
            DateTime timeNotify = DateTime.Now.AddMinutes(1);

            TimeSpan time = timeNotify - DateTime.Now;

            NotificationManager.SendWithAppIcon(time, title, content, Color.white,NotificationIcon.Bell);

            //지정된 시간에 알림하는 기능
            DateTime specifiedTime = Convert.ToDateTime("19:30:00 PM");

            TimeSpan tempTime = specifiedTime - DateTime.Now;

            if(tempTime.Ticks>0)
            {
                NotificationManager.SendWithAppIcon(time, title, content, Color.black, NotificationIcon.Star);
            }
        }

#endif
    }

}
