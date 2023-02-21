using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonController : MonoBehaviour
{
    public GameObject panel;
    public GameObject text_enemy, text_egg;
    public int point_enemy = 0;
    public int point_egg = 0;

    public void Start()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
        text_enemy.GetComponent<Text>().text = ("" + point_enemy).ToString();
    }

    internal void setPoint()
    {
        throw new NotImplementedException();
    }

    // Start is called before the first frame update
    public void StartGame()
    {
        Time.timeScale = 1;
        
    }

    private void Update()
    {
       if (Time.timeScale == 1)
        {
            panel.SetActive(false);
        }
        
    }

    public void setPoint(int i)
    {

        if (i == 1) // enemy
        {
            point_enemy = point_enemy + 1;
            text_enemy.GetComponent<Text>().text = point_enemy.ToString();
        }
        if (i == 2) // egg
        {
            point_egg = point_egg + 1;
            text_egg.GetComponent<Text>().text = point_egg.ToString();
        }
    }
    public void reStartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
