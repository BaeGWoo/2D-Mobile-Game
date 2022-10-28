using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class Data
{
    public int Maxscore;
    public int money;

}


public class DataManager : MonoBehaviour
{
    public int currentScore=0;
    public static DataManager instance;
    public Data data = new Data();


    void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }

        //파일 생성
        //현재 PC의 경로에 저장->모바일로 운영시 제이슨 데이터를 찾을 수 없음

        //모바일, PC, WebGL 해당 경로가 정확하게 배치되어서 저장시키쥽니다.
        Debug.Log(Application.persistentDataPath);


        //Save();
        Load();

      
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            data.money++;
            currentScore++;

            if (data.Maxscore < currentScore)
                data.Maxscore = currentScore;

            Debug.Log("현재 스코어 : "+currentScore);
            Debug.Log("최고 스코어 : " + data.Maxscore);
            Save();
        }
    }

   public void Save()
    {
        string json = JsonUtility.ToJson(data);

        //암호화
        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(json);
        string code = System.Convert.ToBase64String(bytes);

        File.WriteAllText(Application.persistentDataPath + "/GameData.json", code);


    }

    public void Load()
    {
        string jsonData = File.ReadAllText(Application.persistentDataPath + "/GameData.json");


        //암호화
        byte[] bytes = System.Convert.FromBase64String(jsonData);
        string code = System.Text.Encoding.UTF8.GetString(bytes);
        
        
        data = JsonUtility.FromJson<Data>(code);

    }
}
