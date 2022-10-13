using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public GameObject playerName;

    public TextMeshProUGUI BestScoreText;

    private void Start()
    {
        BestScoreText.text = "Best Score : " + GameManager.instance.PlayerName + " : " + GameManager.instance.PlayerScore;
    }

    public void StartNew()
    {
        GameManager.instance.CurrentPlayerName = playerName.GetComponent<TMP_InputField>().text;

        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
