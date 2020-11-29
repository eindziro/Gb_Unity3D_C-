using System;
using UnityEngine;

namespace Gb_Unity3D_CSharp
{
    
    public class HealthBarGUI:MonoBehaviour
    {
        private int _currentHP = 50;
        private int _maxHP = 100;
        
        private void OnGUI()
        {
            //TODO: переделать модель\контроллер\view урона и жизней
            //ХП будет выводить по нормальному через VIEW, нарисовал так только чтобы задание было выполнено
            GUI.Label(new Rect(Screen.width/2 - 100,0, 100, 20 ),$"HP : {_currentHP} / {_maxHP}" );
        }
        
    }
}