using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameControll : MonoBehaviour
{
    public GameObject img;
    public GameObject table;
    public GameObject dialogueObject;
    public GameObject questionObject;
    public GameObject FaideIn;

    public TextMeshProUGUI questionText;

    private void Start()
    {
        ChangeObjectTag(table.gameObject, "Table");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Table"))
        {
            StartCoroutine(ShowImg());
            ChangeObjectTag(table.gameObject, "Untagged");

            questionObject.SetActive(false);

            questionText.text = "Leave the house";
            other.isTrigger = false;
        }

        if (other.CompareTag("NextLocation"))
        {
            FaideIn.SetActive(true);
        }
    }

    private IEnumerator ShowImg()
    {
        yield return new WaitForSeconds(1);
        img.SetActive(true);
        
        yield return new WaitForSeconds(5f);
        img.SetActive(false);
        dialogueObject.SetActive(true);
    }

    private void ChangeObjectTag(GameObject obj, string newTag)
    {
        obj.tag = newTag;
    }
}
