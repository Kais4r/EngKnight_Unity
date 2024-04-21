using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LoadNoteContent : MonoBehaviour
{
    private GameManagerSingleton _gameManagerSingleton;
    [SerializeField] private TMP_InputField _inputField;

    private void Start()
    {
        LoadNote();
    }

    public void LoadNote()
    {
        _gameManagerSingleton = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerSingleton>();
        _inputField.text = _gameManagerSingleton.noteContent;
    }
}
