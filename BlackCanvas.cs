using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCanvas : MonoBehaviour
{
    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    public void toAlphaV() { StartCoroutine(ToAlpha()); }
    public void toBlackV() { StartCoroutine(ToABlack()); }


    public IEnumerator ToAlpha()
    {
        for(float i = 1; i >-0.5f; i -= 0.05f)
        {
            this.GetComponent<CanvasGroup>().alpha = i;
            yield return new WaitForEndOfFrame();
        }

        this.gameObject.SetActive(false);

        yield break;
    }

    public IEnumerator ToABlack()
    {
        this.gameObject.SetActive(true);


        for (float i = 0; i < 1; i += 0.05f)
        {
            this.GetComponent<CanvasGroup>().alpha = i;
            yield return new WaitForEndOfFrame();
        }

        yield break;
    }
}
