﻿using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Panuon.UI.Silver.Internal.TemplateSelectors
{
    class IconPresenterContentTemplateSelector : DataTemplateSelector
    {
        private static List<string> _imageFileFormats = new List<string>()
        {
            ".bmp", ".jpg", ".jpe", ".png", ".jpeg", ".gif", ".tif", ".ico"
        };

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item != null)
            {
                if (item is ImageSource)
                {
                    return CreateImageDataTemplate(item);
                }
                else if (item is string stringItem)
                {
                    if(_imageFileFormats.Any(x => stringItem.EndsWith(x)))
                    {
                        return CreateImageDataTemplate(item);
                    }
                }
            }

            return CreateContentDataTemplate(item);
        }

        #region Function
        private DataTemplate CreateImageDataTemplate(object item)
        {
            var factory = new FrameworkElementFactory(typeof(Image));
            var imageSource = new Binding() { Source = item };
            factory.SetBinding(Image.SourceProperty, imageSource);
            factory.SetBinding(Image.VerticalAlignmentProperty, new Binding() { RelativeSource = new RelativeSource(RelativeSourceMode.TemplatedParent), Path = new PropertyPath(ContentControl.VerticalContentAlignmentProperty) });
            factory.SetBinding(Image.HorizontalAlignmentProperty, new Binding() { RelativeSource = new RelativeSource(RelativeSourceMode.TemplatedParent), Path = new PropertyPath(ContentControl.HorizontalContentAlignmentProperty) });
            factory.SetValue(Image.FocusableProperty, false);
            factory.SetValue(RenderOptions.BitmapScalingModeProperty, BitmapScalingMode.HighQuality);
            var dataTemplate = new DataTemplate
            {
                VisualTree = factory
            };
            dataTemplate.Seal();
            return dataTemplate;
        }

        private DataTemplate CreateContentDataTemplate(object item)
        {
            var factory = new FrameworkElementFactory(typeof(ContentControl));
            factory.SetBinding(ContentControl.ContentProperty, new Binding() { Source = item });
            factory.SetValue(ContentControl.FocusableProperty, false);
            factory.SetBinding(ContentControl.VerticalAlignmentProperty, new Binding() { RelativeSource = new RelativeSource(RelativeSourceMode.FindAncestor, typeof(IconPresenter), 1), Path = new PropertyPath(IconPresenter.VerticalContentAlignmentProperty) });
            factory.SetBinding(ContentControl.HorizontalAlignmentProperty, new Binding() { RelativeSource = new RelativeSource(RelativeSourceMode.FindAncestor, typeof(IconPresenter), 1), Path = new PropertyPath(IconPresenter.HorizontalContentAlignmentProperty) });
            var dataTemplate = new DataTemplate
            {
                VisualTree = factory
            };
            dataTemplate.Seal();
            return dataTemplate;
        }
        #endregion

    }

}
