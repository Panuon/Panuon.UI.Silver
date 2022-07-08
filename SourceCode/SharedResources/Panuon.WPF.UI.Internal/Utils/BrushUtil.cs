﻿using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Panuon.WPF.UI.Internal.Utils
{
    static class BrushUtil
    {
        public static VisualBrush GetSuperposedVisualBrush(Brush background, Brush foreground, double opacity)
        {
            var border = new Border()
            {
                Width = 1,
                Height = 1,
                Background = background,

                Child = new Rectangle()
                {
                    Fill = foreground,
                    Opacity = opacity
                }
            };
            return new VisualBrush(border);
        }

        public static VisualBrush GetStackedVisualBrush(Brush brush1, Brush brush2, Orientation oritention, double offset)
        {
            var grid = new Grid()
            {
                Width = 1,
                Height = 1,
            };
            if (oritention == Orientation.Horizontal)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new System.Windows.GridLength(offset, System.Windows.GridUnitType.Star) });
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new System.Windows.GridLength(1 - offset, System.Windows.GridUnitType.Star) });

                var rectangle1 = new Rectangle() { Fill = brush1 };
                grid.Children.Add(rectangle1);

                var rectangle2 = new Rectangle() { Fill = brush2 };
                Grid.SetColumn(rectangle2, 1);
                grid.Children.Add(rectangle2);
            }
            else
            {
                grid.RowDefinitions.Add(new RowDefinition() { Height = new System.Windows.GridLength(offset, System.Windows.GridUnitType.Star) });
                grid.RowDefinitions.Add(new RowDefinition() { Height = new System.Windows.GridLength(1 - offset, System.Windows.GridUnitType.Star) });

                var rectangle1 = new Rectangle() { Fill = brush1 };
                grid.Children.Add(rectangle1);

                var rectangle2 = new Rectangle() { Fill = brush2 };
                Grid.SetRow(rectangle2, 1);
                grid.Children.Add(rectangle2);
            }

            return new VisualBrush(grid);
        }

    }
}
