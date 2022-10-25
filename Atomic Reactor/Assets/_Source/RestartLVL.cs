using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLVL : MonoBehaviour
{
    public void Restart() => SceneManager.LoadScene(sceneBuildIndex: 0);
}
