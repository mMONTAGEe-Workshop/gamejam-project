using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    public Text fpsText;
    public float updateInterval = 0.2f;

    private float fpsAccumulator = 0f;
    private int fpsFrames = 0;
    private float fpsTimeLeft = 0f;

    private void Start()
    {
        if (fpsText == null)
        {
            Debug.LogError("FPSCounter: No Text object referenced!");
            enabled = false;
            return;
        }

        fpsTimeLeft = updateInterval;
    }

    private void Update()
    {
        fpsTimeLeft -= Time.deltaTime;
        fpsAccumulator += Time.timeScale / Time.deltaTime;
        fpsFrames++;

        if (fpsTimeLeft <= 0f)
        {
            float fps = fpsAccumulator / fpsFrames;
            fpsText.text = string.Format("{0:F2} FPS", fps);
            fpsTimeLeft = updateInterval;
            fpsAccumulator = 0f;
            fpsFrames = 0;
        }
    }
}
