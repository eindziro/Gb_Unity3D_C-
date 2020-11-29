﻿namespace Gb_Unity3D_CSharp
{
    /// <summary>
    /// Модель стены
    /// </summary>
    public sealed class Wall:BaseObject, ISelectObj
    {
        /// <summary>
        /// Вернуть сообщение при выделении
        /// </summary>
        /// <returns></returns>
        public string GetMessage()
        {
            return Name;
        }
    }
}