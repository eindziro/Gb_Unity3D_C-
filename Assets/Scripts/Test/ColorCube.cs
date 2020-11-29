using System;
using UnityEngine;

namespace Gb_Unity3D_CSharp
{
    public class ColorCube : MonoBehaviour
    {
        private const float SLIDER_MIN_VALUE = 0f;
        private const float SLIDER_MAX_VALUE = 1f;

        [SerializeField] private MeshRenderer _meshRenderer;

        private float sliderValue = 0f;
        private Color _currentColor;

        private void OnGUI()
        {
            _currentColor = HandleColorSlider(new Rect(10, 30, 200, 20), _currentColor);
            _meshRenderer.material.color = _currentColor;
        }

        private float CreateLabelSlider(Rect rect, float sliderValue, string labelText = "")
        {
            Rect labelRect = new Rect(rect.x, rect.y, rect.width / 2, rect.height);
            GUI.Label(labelRect, labelText);
            Rect sliderRect = new Rect(rect.x + rect.width / 2, rect.y, rect.width / 2, rect.height);
            sliderValue = GUI.HorizontalSlider(sliderRect, sliderValue, SLIDER_MIN_VALUE, SLIDER_MAX_VALUE);
            return sliderValue;
        }

        private Color HandleColorSlider(Rect rect, Color rgba)
        {
            rgba.r = CreateLabelSlider(rect, rgba.r, "Red");
            rect.y += 20;
            rgba.g = CreateLabelSlider(rect, rgba.g, "Green");
            rect.y += 20;
            rgba.b = CreateLabelSlider(rect, rgba.b, "blue");
            rect.y += 20;
            rgba.a = CreateLabelSlider(rect, rgba.a, "Alpha");
            return rgba;
        }
    }
}