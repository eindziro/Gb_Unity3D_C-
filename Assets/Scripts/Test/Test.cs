using UnityEngine;

namespace Gb_Unity3D_CSharp
{
    public class Test : MonoBehaviour
    {
        private void Start()
        {
            FindObjectOfType<FlashLightModel>().Layer = 2;
        }
    }
}