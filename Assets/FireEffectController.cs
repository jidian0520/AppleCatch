using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ファイアエフェクトを自動的に消すためのスクリプト
public class FireEffectController : MonoBehaviour
{
    float dur;
    void Start()
    {
        dur = GetComponent<ParticleSystem>().main.duration;
        Destroy(gameObject, dur);
    }
}
