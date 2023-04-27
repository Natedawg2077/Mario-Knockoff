using UnityEngine;
using UnityEngine.UI;

public class BlinkingText : MonoBehaviour
{
    public float blinkTime = 0.5f; // time between blinks
    private Text textComponent;

    private void Start()
    {
        textComponent = GetComponent<Text>();
        InvokeRepeating("ToggleVisibility", 0, blinkTime);
    }

    private void ToggleVisibility()
    {
        textComponent.enabled = !textComponent.enabled;
    }
}