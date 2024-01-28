using System.Collections;
using TMPro;
using UnityEngine;

public class RandomPhrase : MonoBehaviour
{
    public string[] phrases;
    public TextMeshProUGUI displayText;
    public GameObject displayObject;

    private void Start()
    {

    }

    private void OnMouseDown()
    {
        SelectAndDisplayRandomPhrase();
    }

    private void SelectAndDisplayRandomPhrase()
    {
        if (phrases.Length > 0)
        {
            int randomIndex = Random.Range(0, phrases.Length);
            string randomPhrase = phrases[randomIndex];
            Debug.Log("Selected phrase: " + randomPhrase);
            if (displayText != null)
            {
                displayObject.SetActive(true);
                displayText.text = randomPhrase;
                StartCoroutine(hideGameObject());
            }
            else
            {
                Debug.LogWarning("Text display component not assigned.");
            }
        }
        else
        {
            Debug.LogWarning("No phrases available in the array.");
        }
    }

    private IEnumerator hideGameObject()
    {
        yield return new WaitForSeconds(10f);
        displayObject.SetActive(false);
    }
}
