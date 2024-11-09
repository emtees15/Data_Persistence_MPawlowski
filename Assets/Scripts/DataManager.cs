using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static DataManager instance;

    public string name;

    public string bestScoreName;
    public int bestScore;

    public class BestScore
    {
        string name;
        int bestScore;
    }

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
    }

}
