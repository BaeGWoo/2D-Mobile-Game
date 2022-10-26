using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class UnityADs : MonoBehaviour
{

    private string androidID = "4979865";
    private int gameMoney = 0;

    void Start()
    {
        Advertisement.Initialize(androidID);
        ShowBanner();
    }

  
    public void ShowInitialize()
    {
        if(Advertisement.IsReady())
        {
            Advertisement.Show("Interstitial_Android");
        }
    }

   public void ShowBanner()
    {
        if(Advertisement.IsReady("Banner_Android"))
        {

            //배너 광고의 위치설정
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);


            //배너 광고 보여주기
            Advertisement.Banner.Show("Banner_Android");

            
        }

        else
        {
            StartCoroutine(RepeateBanner());
        }


    }

    private IEnumerator RepeateBanner()
    {
        yield return new WaitForSeconds(1f);
        ShowBanner();
    }


    private void HandleShowResult(ShowResult result)
    {
        switch(result)
        {
            //광고를 다 봤을 때
            case ShowResult.Finished:
                gameMoney += 100;

                break;

            //광고를 스킵했을때
            case ShowResult.Skipped:
                Debug.Log("광고를 스킵했습니다.");
                break;


            //보상형 나오는 데 실패했을 때
            case ShowResult.Failed:
                Debug.LogError("광고 송출을 실패했습니다.");
                break;


        }
    }

    public void ShowRewarded()
    {
        if(Advertisement.IsReady())
        {
            var options = new ShowOptions { resultCallback = HandleShowResult };

            Advertisement.Show("Rewarded_Android", options);
        }

        
    }
}
