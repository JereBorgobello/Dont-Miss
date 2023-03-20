using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManage : MonoBehaviour
{
    public Text puntosText;

    int puntos;


    void Update()
    {
        puntosText.text = puntos.ToString();
    }

    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }

    public void AddPunto()
    {
        puntos += 1;
    }


}
