using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{

    public float lightSpeed = 0.5f; // 明るくなる速度

    public float startPoint = 1.0f; // 背面の開始時の明るさ

    public float endPoint = 18.0f; // 背面の終了時の明るさ

    public Color lightColor = Color.white; // 背面のライトの色

    Light lightObject;



    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("プレファブ作成");
        lightObject = GetComponent<Light>();
        setLightComponent(lightObject, lightColor, startPoint);
    }

    // Update is called once per frame
    void Update()
    {
        graduallyLightAndDarkness(startPoint, endPoint);
    }

    // 色、開始点セット関数
    void setLightComponent(Light light, Color color, float intensity){
        
        light.color = color;
        light.intensity = intensity;

    }

    // 徐々に明暗をつける関数
    void graduallyLightAndDarkness(float startPoint, float endPoint){

            if(startPoint < endPoint){
                // 開始点の方が終了点より小さい場合、徐々に明るくする
                if(lightObject.intensity < endPoint){
                    lightObject.intensity += lightSpeed;
                }

            }else if ((startPoint > endPoint)){
                // 終了点の方が開始点より小さい場合、徐々に明るくする        
                if(lightObject.intensity > endPoint){
                    lightObject.intensity -= lightSpeed;
                }

            }
    }
}
