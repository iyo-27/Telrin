using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulateScene : MonoBehaviour
{
    public LightController lightPrefabB;
    public LightController lightPrefabR;
    public LightController lightPrefabL;

    [SerializeField] private TelrinData excelData;


    // Start is called before the first frame update
    void Start()
    {

        // 背面ポイントライト
        LightController lightB = Instantiate(lightPrefabB, new Vector3( 0.16f, 1.10f, 4.87f), Quaternion.identity);
        lightB.lightColor = SelectColor(excelData.Data[0].color);

        // 右側ポイントライト
        LightController lightR = Instantiate(lightPrefabR, new Vector3( 0.9f, 0.97f, 3.55f), Quaternion.identity);
        lightR.lightColor = SelectColor(excelData.Data[1].color);

        // 左側ポイントライト
        LightController lightL = Instantiate(lightPrefabL, new Vector3( -0.9f, 0.97f, 3.55f), Quaternion.identity);
        lightL.lightColor = SelectColor(excelData.Data[1].color);
    }

    // Update is called once per frame
    void Update()
    {
        
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
