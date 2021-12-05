using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOpacity : MonoBehaviour
{
    CanvasGroup group;

    private void Awake()
    {
        this.group = this.GetComponent<CanvasGroup>();
    }

    public void To1()
    {
        StartCoroutine(To1E());
    }

    public void To0()
    {
        StartCoroutine(To0E());
    }

    public IEnumerator To0E()
    {
        for (float i = 1; i > -0.5f; i -= 0.05f)
        {
            this.group.alpha = i;
            yield return new WaitForEndOfFrame();
        }

        this.gameObject.SetActive(false);

        yield break;
    }

    public IEnumerator To1E()
    {
        this.gameObject.SetActive(true);


        for (float i = 0; i < 1; i += 0.05f)
        {
            this.group.alpha = i;
            yield return new WaitForEndOfFrame();
        }

        yield break;
    }

}
