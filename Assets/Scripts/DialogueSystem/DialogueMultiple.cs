using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DialogueSystem
{
    public class DialogueMultiple : MonoBehaviour
    {
        [SerializeField] private GameObject dialogueObject;
        [SerializeField] private GameObject questionObject;

        public PlayerMovement playerMovement;

        void Awake()
        {
            StartCoroutine(dialoguesSequence());
            playerMovement.enabled = false;
        }

        public IEnumerator dialoguesSequence()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                Deactivate();
                transform.GetChild(i).gameObject.SetActive(true);
                yield return new WaitUntil(() => transform.GetChild(i).GetComponentInChildren<DialogueLine>().finished);
            }

            dialogueObject.SetActive(false);
            questionObject.SetActive(true);
            playerMovement.enabled = true;
        }

        private void Deactivate()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}

