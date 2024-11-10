using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static DataManager instance;

    public string name;

    public string bestScoreName;
    public int bestScore;

  

    public void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
        bestScore = 0;
        name = "";
        bestScoreName = name;
        LoadBest();
       
    }

    [System.Serializable]
    public class BestScore
    {
        public string name;
        public string bestScoreName;
        public int bestScore;
    }

    public void saveBest()
    {
        BestScore data = new BestScore();
        data.name = name;
        data.bestScoreName = bestScoreName;
        data.bestScore = bestScore;

        string json = JsonUtility.ToJson(data);    
        File.WriteAllText(Application.persistentDataPath + "/saveBestFile.json", json);
    }

    public void LoadBest()
    {
        string path = Application.persistentDataPath + "/saveBestFile.json", json;
        if (File.Exists(path))
        {
            string json2 = File.ReadAllText(path);
            BestScore data2 = JsonUtility.FromJson<BestScore>(json2);

            this.bestScore = data2.bestScore;
            this.bestScoreName= data2.bestScoreName;
            this.name = data2.name;
        }
    }

}
