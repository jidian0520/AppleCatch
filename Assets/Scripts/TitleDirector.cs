using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour
{
    public GameObject appleSpin;
    public void OnPressStartButton()
    {
        //STARTボタンが押したらタイトルシーンからゲームシーンへ切り替える
        SceneManager.LoadScene("SelectScene");
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        appleSpin.transform.Rotate(new Vector3(0, 0.5f, 0));
    }
}
