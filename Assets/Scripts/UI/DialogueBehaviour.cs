using System.Collections;
using TMPro;
using UnityEngine;

public class DialogueBehaviour : MonoBehaviour
{
    private TextMeshProUGUI TextMesh;
    public int CharactersPerSecond = 30;

    public void Awake()
    {
        TextMesh = GetComponent<TextMeshProUGUI>();
    }

    private IEnumerator RevealText(float charsPerSecond)
    {
        int counter = 0;

        while (counter <= TextMesh.textInfo.characterCount)
        {
            counter += 1;
            TextMesh.maxVisibleCharacters = counter;
            yield return new WaitForSeconds(1 / charsPerSecond);
        }
    }

    public void Display(string text)
    {
        Display(text, CharactersPerSecond);
    }

    public void Display(string text, int charsPerSecond)
    {
        TextMesh.text = text;
        TextMesh.ForceMeshUpdate();
        StartCoroutine(RevealText(charsPerSecond));
    }
}
