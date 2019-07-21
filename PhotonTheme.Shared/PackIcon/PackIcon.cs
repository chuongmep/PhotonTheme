﻿using System.Windows;
using PhotonTheme.Shared.ControlzEx;

namespace PhotonTheme.Shared.PackIcon
{
    /// <summary>
    /// Icon from the Material Design Icons project, <see cref="https://materialdesignicons.com/"/>.
    /// </summary>
    public class PackIcon : PackIconBase<PackIconKind>
    {
        static PackIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PackIcon), new FrameworkPropertyMetadata(typeof(PackIcon)));
        }

        public PackIcon() : base(PackIconDataFactory.Create) { }
    }
}
