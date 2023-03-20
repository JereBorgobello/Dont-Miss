using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyButton : MonoBehaviour
{

    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }

}