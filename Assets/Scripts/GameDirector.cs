using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject timerText;
    GameObject pointText;
    float time = 30.0f;
    int point = 0;
    GameObject generator;
    GameObject GameEndButton;

    public void GetApple()
    {
        this.point += 100;
    }

    public void GetBomb()
    {
        this.point /= 2;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.generator = GameObject.Find("ItemGenerator");
        this.timerText = GameObject.Find("Time");
        this.pointText = GameObject.Find("Point");
        GameEndButton = GameObject.Find("GameEnd");
        GameEndButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;

        if (this.time < 0)
        {
            this.time = 0;
            GameEndButton.SetActive(true);
            this.generator.GetComponent<ItemGenerator>().setParameter(10000f, 0, 0);
        }
        else if (0 <= this.time && this.time < 5)
        {
            this.generator.GetComponent<ItemGenerator>().setParameter(0.7f - GVal.span, -0.04f - GVal.speed, 3 + GVal.ratio); //span, speed, ratioの意味
        }
        else if (5 <= this.time && this.time < 12)
        {
            this.generator.GetComponent<ItemGenerator>().setParameter(0.5f - GVal.span, -0.05f - GVal.speed, 6 + GVal.ratio);
        }
        else if (12 <= this.time && this.time < 23)
        {
            this.generator.GetComponent<ItemGenerator>().setParameter(0.8f - GVal.span, -0.04f - GVal.speed, 4 + GVal.ratio);
        }
        else if (23 <= this.time && this.time < 30)
        {
            this.generator.GetComponent<ItemGenerator>().setParameter(1.0f - GVal.span, -0.03f - GVal.speed, 2 + GVal.ratio);
        }


        this.timerText.GetComponent<Text>().text = this.time.ToString("F1");
        this.pointText.GetComponent<Text>().text = this.point.ToString() + "point";
    }

    public void onClickGameEndButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
