using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch_Scene : MonoBehaviour
{
    public void NextLevel(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

}
