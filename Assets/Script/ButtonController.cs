using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public string GoSceneName;
    public string BackSceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // シュミレーション開始ボタン
    public void GoSimulate() {

        SceneManager.LoadScene(GoSceneName);
    }
    
    // シュミレーションリセットボタン
    public void ResetSimulate() {

        SceneManager.LoadScene(BackSceneName);
    }
}
