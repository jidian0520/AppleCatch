using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//100ポイントのエフェクトを削除するためのスクリプト
//上昇しながら消えていく処理
public class pointEffectController : MonoBehaviour
{
    float lifeTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Time.deltaTime, 0);
        //徐々に透明にする
        Color color = GetComponent<TextMesh>().color;
        color.a -= Time.deltaTime;
        GetComponent<TextMesh>().color = color;
    }
}
