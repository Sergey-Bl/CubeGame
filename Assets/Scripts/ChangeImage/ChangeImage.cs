using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ChangeImage
{
    public class ChangeImage : MonoBehaviour
    {
        public Image original;
        public Sprite newSprite;
        public TextMeshProUGUI oldText;
        public string newText;

        public void Update()
        {
            
        }

        public void NewImage()
        {
            original.sprite = newSprite;
        }

        public void newsText()
        {
            oldText.text = newText;
        }
    }
    
}
