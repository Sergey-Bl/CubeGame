using System;
using UnityEngine;

namespace UI
{
    public class MenuManager : MonoBehaviour
    {
        [SerializeField] private RectTransform[] _windows;

        public void OpenWindow(String windowName)
        {
            foreach (var window in _windows)
            {
                if (window.name == windowName)
                {
                    window.gameObject.SetActive(true);
                }
                else
                {
                    window.gameObject.SetActive(false);
                }
            }
        }
    }
}