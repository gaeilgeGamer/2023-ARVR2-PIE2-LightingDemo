using UnityEngine;
using UnityEngine.UI;

public class CubeColorChanger : MonoBehaviour
{
    public Slider colorSlider;
    public Material cubeMaterial;

    private void Start()
    {
        colorSlider.onValueChanged.AddListener(ChangeCubeColor);
    }

    private void ChangeCubeColor(float value)
    {
        cubeMaterial.color = Color.Lerp(Color.red, Color.blue, value);
    }
}