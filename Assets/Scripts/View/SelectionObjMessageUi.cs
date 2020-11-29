using UnityEngine;
using UnityEngine.UI;
namespace Gb_Unity3D_CSharp
{
    /// <summary>
    /// Представление для выделенных объектов
    /// </summary>
    public sealed class SelectionObjMessageUi : MonoBehaviour
    {
        private Text _text;

        private void Awake()
        {
            _text = GetComponent<Text>();
        }

        public string Text
        {
            set => _text.text = $"{value}";
        }

        public void SetActive(bool value)
        {
            _text.gameObject.SetActive(value);
        }
    }
}