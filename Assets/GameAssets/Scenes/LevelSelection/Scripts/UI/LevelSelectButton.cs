using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelSelectButton : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    private GameManagerSingleton _gameManagerSingleton;
    private void Awake()
    {
        _gameManagerSingleton = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerSingleton>();
    }
    public void TurnOnOrOffPanel(string level)
    {
        _gameManagerSingleton.cefrLevel = level;
        _panel.SetActive(true);
    }
}
