using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using DG.Tweening;


using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public float fadeTime = 1f;
    public float bounceTime = 1f;
    private CanvasGroup canvasGroup;
    private bool canTogglePause = true;
    Sequence sequence;

    // Start is called before the first frame update
    void Start()
    {
        sequence = DOTween.Sequence();
        this.transform.localScale = Vector3.zero;
        canvasGroup = this.GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseScreen();
        }
    }

    public void TogglePauseScreen()
    {
        if (canTogglePause == true)
        {
            this.transform.DOKill();
            Sequence sequence = DOTween.Sequence();

            if (this.transform.localScale == Vector3.zero)
            {

                sequence.Append(this.transform.DOScale(new Vector3(1.1f, 1.1f, 1.1f), fadeTime));
                sequence.Append(this.transform.DOScale(Vector3.one, bounceTime));
                sequence.Insert(0f, canvasGroup.DOFade(1f, fadeTime));

                sequence.Play();

            }

            else
            {
                this.transform.DOScale(Vector3.zero, fadeTime);
                canvasGroup.DOFade(0f, fadeTime);
            }

            canTogglePause = false;

            StartCoroutine(WaitForPauseMenu());
        }

    }
    private IEnumerator WaitForPauseMenu()
    {
        yield return new WaitForSeconds(fadeTime);
        canTogglePause = true;
    }

}

