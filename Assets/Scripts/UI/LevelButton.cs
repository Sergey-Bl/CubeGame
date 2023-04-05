using System;
using Configs;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UI
{
    public class LevelButton : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _numberText;
        [SerializeField] private Button _button;
        private string _sceneName;

        public void DrawLevel(String LevelNumber, string sceneName, bool active)
        {
            _numberText.text = LevelNumber;
            _sceneName = sceneName;

            _button.interactable = active;
            
            _button.onClick.AddListener(onClick);
        }

        private void onClick()
        {
            SceneManager.LoadScene(_sceneName);
        }
    }
}