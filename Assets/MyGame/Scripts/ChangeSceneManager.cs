using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneManager : MonoBehaviour
{
   public void changeScece(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
}
