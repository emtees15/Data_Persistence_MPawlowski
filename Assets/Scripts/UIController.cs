using System.Collections;
using System.Collections.Generic;

#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update

    public InputField name;
    public Text bestScore;
    void Start()
    {
        bestScore.text = "Best Score: " + DataManager.instance.bestScoreName + " " + DataManager.instance.bestScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartClick()
    {
        DataManager.instance.name = this.name.text;
        SceneManager.LoadScene(1);
    }

    public void ExitClick()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
