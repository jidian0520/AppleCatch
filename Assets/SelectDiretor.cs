using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectDiretor : MonoBehaviour
{
    //public void OnPressEasyButton()
    //{
    //    //STARTボタンが押したらタイトルシーンからゲームシーンへ切り替える
    //    SceneManager.LoadScene("GameScene");
    //}
    //public void OnPressNormalButton()
    //{
    //    //STARTボタンが押したらタイトルシーンからゲームシーンへ切り替える
    //    SceneManager.LoadScene("GameScene");
    //}
    //public void OnPressHardButton()
    //{
    //    //STARTボタンが押したらタイトルシーンからゲームシーンへ切り替える
    //    SceneManager.LoadScene("GameScene");
    //}

    public void OnPressButton(string Rank)
    {
        switch (Rank)
        {
            case "Easy":
                GVal.span = 0;
                GVal.speed = 0;
                GVal.ratio = 0;
                break;

            case "Normal":
                GVal.span = 0.05f;
                GVal.speed = 0.05f;
                GVal.ratio = 1;
                break;

            case "Hard":
                GVal.span = 0.1f;
                GVal.speed = 0.1f;
                GVal.ratio = 2;
                break;
        }

        SceneManager.LoadScene("GameScene");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
