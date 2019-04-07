using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    public void changescene(string scenename)
    {
        SceneManager.LoadScene(0);
    }
}