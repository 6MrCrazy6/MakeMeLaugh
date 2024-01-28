using System.Collections;
using UnityEngine;
using TMPro;
using MusicSFXControl;
using UnityEngine.UIElements;

namespace DialogueSystem
{
    public class DialogueSystemBase : MonoBehaviour
    {
        public bool finished {  get; private set; }

        protected IEnumerator WriteText(string input, TextMeshProUGUI textHolder, AudioClip audio)
        {
            for (int i = 0; i < input.Length; i++)
            {
                textHolder.text += input[i];
                SoundManager.instance.PLaySound(audio);
                yield return new WaitForSeconds(0.05f);
            }

            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Mouse0));

            finished = true;
        }
    }
}

