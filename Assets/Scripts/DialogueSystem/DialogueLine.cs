using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace DialogueSystem
{
    public class DialogueLine : DialogueSystemBase
    {
        [Header ("Text Options")]
        [SerializeField] private string input;
        [SerializeField] private TextMeshProUGUI textHolder;

        [Header ("Sound")]
        [SerializeField] private AudioClip audioClip;

        [Header("Charcter Image")]
        [SerializeField] private Sprite characterSprite;
        [SerializeField] private Image imageCharacter;

        private void Start()
        {
            StartCoroutine(WriteText(input, textHolder, audioClip));
            imageCharacter.sprite = characterSprite;
        }
    }
}

