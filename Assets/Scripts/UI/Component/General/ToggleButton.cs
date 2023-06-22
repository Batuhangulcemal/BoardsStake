using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace AsepStudios.UI
{
    public class ToggleButton : ButtonBase
    {
        private readonly Color onColor = ResourceProvider.Colors.Orange;
        private readonly Color offColor = ResourceProvider.Colors.Cream;
        
        public bool IsOn { get; private set; } = false;

        private void Awake()
        {
            SetOn(IsOn);
        }

        public void SetOn(bool value)
        {
            IsOn = value;

            ButtonColor = value ? onColor : offColor;
        }
    }
}
