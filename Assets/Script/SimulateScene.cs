using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimulateScene : MonoBehaviour
{
    public LightController lightPrefabB;
    private LightController lightB; 
    public LightController lightPrefabR;
    private LightController lightR; 
    public LightController lightPrefabL;
    private LightController lightL; 
    private float interval;
    //Stopwatchのインスタンス作成
    private System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
    [SerializeField] private TelrinData excelData;
    private int orderNo = 0; 

    // Start is called before the first frame update
    void Start()
    {
        // ストップウォッチの起動
        this.stopwatch.Start();
        // ライトを灯し、最初のインターバルを取得する
        CreateLightObject();
        this.interval = SetLightColor(this.orderNo);
        
    }

    void FixedUpdate(){
        if(this.interval <= (float)this.stopwatch.Elapsed.TotalSeconds){
            // ストップウォッチを止める
            this.stopwatch.Stop();

            // 次の順番を登録する
            this.orderNo += 1;

            if(this.orderNo >= excelData.Data.Count){
                // 最後の場合ライトを消す or スタート画面に戻る
                SceneManager.LoadScene("main");
            } else {
                // 既存オブジェクトの削除
                DestroyLightObject();
                // ライトオブジェクトの生成
                CreateLightObject();
                this.interval = SetLightColor(this.orderNo);
            }

            // ストップウォッチ再始動
            stopwatch.Restart();
        }
    }

    // オブジェクト生成関数
    private void CreateLightObject(){
        this.lightB = Instantiate(lightPrefabB, new Vector3( 0.16f, 1.10f, 4.87f), Quaternion.identity);
        this.lightR = Instantiate(lightPrefabR, new Vector3( 0.9f, 0.97f, 3.55f), Quaternion.identity);
        this.lightL = Instantiate(lightPrefabL, new Vector3( -0.9f, 0.97f, 3.55f), Quaternion.identity);
    }

    // オブジェクト削除用関数
    private void DestroyLightObject(){
        Destroy(GameObject.FindWithTag("LightB"));
        Destroy(GameObject.FindWithTag("LightR"));
        Destroy(GameObject.FindWithTag("LightL"));
    }

    // オブジェクトにライトを灯す関数
    private float SetLightColor(int no){

        this.lightB.lightColor = SelectColor(excelData.Data[no].color);
        this.lightR.lightColor = SelectColor(excelData.Data[no].color);
        this.lightL.lightColor = SelectColor(excelData.Data[no].color);

        return excelData.Data[no].time;
    }

    private Color SelectColor(string colorName){

        Color color = Color.clear;

        // 色は東海市芸術劇場に合わせて今後増やしていく
        switch (colorName) {
            case "red":
                color = Color.red;
                break;
            
            case "green":
                color = Color.green;
                break;
        }

        return color;

    }
}
