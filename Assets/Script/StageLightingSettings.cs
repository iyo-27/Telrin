using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageLightingSettings : MonoBehaviour
{  
    public string lightName = "Back"; // 明るくなる部位

    public float lightSpeed = 0.1f; // 明るくなる速度

/*
    TODO：徐々に明るさを変える実装そもそもなくていいかも？
    public float startPoint = 1.0f; // 開始時の明るさ

    public float endPoint = 18.0f; // 終了時の明るさ
    */

    public Color lightColor = Color.blue; // 明るくなる部位

}
