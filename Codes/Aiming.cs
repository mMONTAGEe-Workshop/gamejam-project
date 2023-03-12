using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{
    public Animator animator;
    public Camera camera;

    public float maxZrenia = 45f;

    public float minZrenia = 75f;
    Coroutine zoomCoroutine;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            animator.SetBool("Pricel active", true);

            if (zoomCoroutine != null)
                StopCoroutine(zoomCoroutine);

            zoomCoroutine = StartCoroutine(aimFieldOfView(camera, maxZrenia, 0.3f));
        }
        if (Input.GetMouseButtonUp(1))
        {
            animator.SetBool("Pricel active", false);

            if (zoomCoroutine != null)
                StopCoroutine(zoomCoroutine);

            zoomCoroutine = StartCoroutine(aimFieldOfView(camera, minZrenia, 0.3f));
        }
    }

    IEnumerator aimFieldOfView(Camera targetCamera, float toView, float duration)
    {
        float counter = 0;
        float fromView = targetCamera.fieldOfView;

        while (counter < duration)
        {
            counter += Time.deltaTime;

            float viewTime = counter / duration;

            targetCamera.fieldOfView = Mathf.Lerp(fromView, toView, viewTime);

            yield return null;
        }
    }

}