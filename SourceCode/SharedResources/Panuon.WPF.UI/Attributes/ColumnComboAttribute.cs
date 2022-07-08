﻿using System;

namespace Panuon.WPF.UI
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnComboAttribute : Attribute
    {
        #region Properties
        public string ItemsSourceBindingPath { get; set; }

        public string DisplayMemberPath { get; set; }

        public string SelectedValuePath { get; set; }
        #endregion
    }
}
