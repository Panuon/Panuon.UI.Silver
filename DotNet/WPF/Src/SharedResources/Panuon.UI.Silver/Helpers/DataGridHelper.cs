﻿using Panuon.UI.Silver.Internal;
using Panuon.UI.Silver.Internal.Resources;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class DataGridHelper
    {
        #region ComponentResourceKeys
        public static ComponentResourceKey SelectAllButtonStyle { get; } =
            new ComponentResourceKey(typeof(DataGridHelper), nameof(SelectAllButtonStyle));
        #endregion

        #region Properties

        #region CornerRadius
        public static CornerRadius GetCornerRadius(DataGrid dataGrid)
        {
            return (CornerRadius)dataGrid.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(DataGrid dataGrid, CornerRadius value)
        {
            dataGrid.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(DataGridHelper));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(DataGrid dataGrid)
        {
            return (Color?)dataGrid.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(DataGrid dataGrid, Color? value)
        {
            dataGrid.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(DataGridHelper));
        #endregion

        #region IsHorizontalScrollBarCrossingFrozenColumns
        public static bool GetIsHorizontalScrollBarCrossingFrozenColumns(DataGrid dataGrid)
        {
            return (bool)dataGrid.GetValue(IsHorizontalScrollBarCrossingFrozenColumnsProperty);
        }

        public static void SetIsHorizontalScrollBarCrossingFrozenColumns(DataGrid dataGrid, bool value)
        {
            dataGrid.SetValue(IsHorizontalScrollBarCrossingFrozenColumnsProperty, value);
        }

        public static readonly DependencyProperty IsHorizontalScrollBarCrossingFrozenColumnsProperty =
            DependencyProperty.RegisterAttached("IsHorizontalScrollBarCrossingFrozenColumns", typeof(bool), typeof(DataGridHelper));
        #endregion

        #region IsVerticalScrollBarCrossingColumnHeaderPanel
        public static bool GetIsVerticalScrollBarCrossingColumnHeaderPanel(DataGrid dataGrid)
        {
            return (bool)dataGrid.GetValue(IsVerticalScrollBarCrossingColumnHeaderPanelProperty);
        }

        public static void SetIsVerticalScrollBarCrossingColumnHeaderPanel(DataGrid dataGrid, bool value)
        {
            dataGrid.SetValue(IsVerticalScrollBarCrossingColumnHeaderPanelProperty, value);
        }

        public static readonly DependencyProperty IsVerticalScrollBarCrossingColumnHeaderPanelProperty =
            DependencyProperty.RegisterAttached("IsVerticalScrollBarCrossingColumnHeaderPanel", typeof(bool), typeof(DataGridHelper));
        #endregion

        #region MaxRowHeight
        public static double GetMaxRowHeight(DataGrid dataGrid)
        {
            return (double)dataGrid.GetValue(MaxRowHeightProperty);
        }

        public static void SetMaxRowHeight(DataGrid dataGrid, double value)
        {
            dataGrid.SetValue(MaxRowHeightProperty, value);
        }

        public static readonly DependencyProperty MaxRowHeightProperty =
            DependencyProperty.RegisterAttached("MaxRowHeight", typeof(double), typeof(DataGridHelper), new PropertyMetadata(double.PositiveInfinity));
        #endregion 

        #region SortArrowTransformControlStyle
        public static Style GetSortArrowTransformControlStyle(DataGrid dataGrid)
        {
            return (Style)dataGrid.GetValue(SortArrowTransformControlStyleProperty);
        }

        public static void SetSortArrowTransformControlStyle(DataGrid dataGrid, Style value)
        {
            dataGrid.SetValue(SortArrowTransformControlStyleProperty, value);
        }

        public static readonly DependencyProperty SortArrowTransformControlStyleProperty =
            DependencyProperty.RegisterAttached("SortArrowTransformControlStyle", typeof(Style), typeof(DataGridHelper));
        #endregion

        #region SortArrowVisibility
        public static DataGridSortArrowVisibility GetSortArrowVisibility(DataGrid dataGrid)
        {
            return (DataGridSortArrowVisibility)dataGrid.GetValue(SortArrowVisibilityProperty);
        }

        public static void SetSortArrowVisibility(DataGrid dataGrid, DataGridSortArrowVisibility value)
        {
            dataGrid.SetValue(SortArrowVisibilityProperty, value);
        }

        public static readonly DependencyProperty SortArrowVisibilityProperty =
            DependencyProperty.RegisterAttached("SortArrowVisibility", typeof(DataGridSortArrowVisibility), typeof(DataGridHelper));
        #endregion 

        #region SelectAllButtonStyle
        public static Style GetSelectAllButtonStyle(DataGrid dataGrid)
        {
            return (Style)dataGrid.GetValue(SelectAllButtonStyleProperty);
        }

        public static void SetSelectAllButtonStyle(DataGrid dataGrid, Style value)
        {
            dataGrid.SetValue(SelectAllButtonStyleProperty, value);
        }

        public static readonly DependencyProperty SelectAllButtonStyleProperty =
            DependencyProperty.RegisterAttached("SelectAllButtonStyle", typeof(Style), typeof(DataGridHelper));
        #endregion

        #region ResizeThumbThickness
        public static double GetResizeThumbThickness(DataGrid dataGrid)
        {
            return (double)dataGrid.GetValue(ResizeThumbThicknessProperty);
        }

        public static void SetResizeThumbThickness(DataGrid dataGrid, double value)
        {
            dataGrid.SetValue(ResizeThumbThicknessProperty, value);
        }

        public static readonly DependencyProperty ResizeThumbThicknessProperty =
            DependencyProperty.RegisterAttached("ResizeThumbThickness", typeof(double), typeof(DataGridHelper));
        #endregion

        #region ColumnHeaderPadding
        public static Thickness GetColumnHeaderPadding(DataGrid dataGrid)
        {
            return (Thickness)dataGrid.GetValue(ColumnHeaderPaddingProperty);
        }

        public static void SetColumnHeaderPadding(DataGrid dataGrid, Thickness value)
        {
            dataGrid.SetValue(ColumnHeaderPaddingProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderPaddingProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderPadding", typeof(Thickness), typeof(DataGridHelper));
        #endregion

        #region ColumnHeaderForeground
        public static Brush GetColumnHeaderForeground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(ColumnHeaderForegroundProperty);
        }

        public static void SetColumnHeaderForeground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(ColumnHeaderForegroundProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderForegroundProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderForeground", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region ColumnHeaderBackground
        public static Brush GetColumnHeaderBackground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(ColumnHeaderBackgroundProperty);
        }

        public static void SetColumnHeaderBackground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(ColumnHeaderBackgroundProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderBackgroundProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderBackground", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region ColumnHeaderSortingForeground
        public static Brush GetColumnHeaderSortingForeground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(ColumnHeaderSortingForegroundProperty);
        }

        public static void SetColumnHeaderSortingForeground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(ColumnHeaderSortingForegroundProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderSortingForegroundProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderSortingForeground", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region ColumnHeaderSortingBackground
        public static Brush GetColumnHeaderSortingBackground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(ColumnHeaderSortingBackgroundProperty);
        }

        public static void SetColumnHeaderSortingBackground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(ColumnHeaderSortingBackgroundProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderSortingBackgroundProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderSortingBackground", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region ColumnHeaderSeparatorBrush
        public static Brush GetColumnHeaderSeparatorBrush(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(ColumnHeaderSeparatorBrushProperty);
        }

        public static void SetColumnHeaderSeparatorBrush(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(ColumnHeaderSeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderSeparatorBrushProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderSeparatorBrush", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region ColumnHeaderSeparatorVisibility
        public static Visibility GetColumnHeaderSeparatorVisibility(DataGrid dataGrid)
        {
            return (Visibility)dataGrid.GetValue(ColumnHeaderSeparatorVisibilityProperty);
        }

        public static void SetColumnHeaderSeparatorVisibility(DataGrid dataGrid, Visibility value)
        {
            dataGrid.SetValue(ColumnHeaderSeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderSeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderSeparatorVisibility", typeof(Visibility), typeof(DataGridHelper), new PropertyMetadata(Visibility.Visible));
        #endregion

        #region ColumnHeaderHoverBackground
        public static Brush GetColumnHeaderHoverBackground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(ColumnHeaderHoverBackgroundProperty);
        }

        public static void SetColumnHeaderHoverBackground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(ColumnHeaderHoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderHoverBackgroundProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderHoverBackground", typeof(Brush), typeof(DataGridHelper));


        #endregion

        #region ColumnHeaderHoverForeground
        public static Brush GetColumnHeaderHoverForeground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(ColumnHeaderHoverForegroundProperty);
        }

        public static void SetColumnHeaderHoverForeground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(ColumnHeaderHoverForegroundProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderHoverForegroundProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderHoverForeground", typeof(Brush), typeof(DataGridHelper));


        #endregion

        #region ColumnHeaderClickBackground
        public static Brush GetColumnHeaderClickBackground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(ColumnHeaderClickBackgroundProperty);
        }

        public static void SetColumnHeaderClickBackground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(ColumnHeaderClickBackgroundProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderClickBackgroundProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderClickBackground", typeof(Brush), typeof(DataGridHelper));


        #endregion

        #region ColumnHeaderClickForeground
        public static Brush GetColumnHeaderClickForeground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(ColumnHeaderClickForegroundProperty);
        }

        public static void SetColumnHeaderClickForeground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(ColumnHeaderClickForegroundProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderClickForegroundProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderClickForeground", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region ColumnHeaderPanelCornerRadius
        public static CornerRadius GetColumnHeaderPanelCornerRadius(DataGrid dataGrid)
        {
            return (CornerRadius)dataGrid.GetValue(ColumnHeaderPanelCornerRadiusProperty);
        }

        public static void SetColumnHeaderPanelCornerRadius(DataGrid dataGrid, CornerRadius value)
        {
            dataGrid.SetValue(ColumnHeaderPanelCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderPanelCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderPanelCornerRadius", typeof(CornerRadius), typeof(DataGridHelper));
        #endregion

        #region ColumnHeaderPanelBackground
        public static Brush GetColumnHeaderPanelBackground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(ColumnHeaderPanelBackgroundProperty);
        }

        public static void SetColumnHeaderPanelBackground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(ColumnHeaderPanelBackgroundProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderPanelBackgroundProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderPanelBackground", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region ColumnHeaderPanelBorderBrush
        public static Brush GetColumnHeaderPanelBorderBrush(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(ColumnHeaderPanelBorderBrushProperty);
        }

        public static void SetColumnHeaderPanelBorderBrush(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(ColumnHeaderPanelBorderBrushProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderPanelBorderBrushProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderPanelBorderBrush", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region ColumnHeaderPanelBorderThickness
        public static Thickness GetColumnHeaderPanelBorderThickness(DataGrid dataGrid)
        {
            return (Thickness)dataGrid.GetValue(ColumnHeaderPanelBorderThicknessProperty);
        }

        public static void SetColumnHeaderPanelBorderThickness(DataGrid dataGrid, Thickness value)
        {
            dataGrid.SetValue(ColumnHeaderPanelBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderPanelBorderThicknessProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderPanelBorderThickness", typeof(Thickness), typeof(DataGridHelper));
        #endregion

        #region ColumnHeaderPanelShadowColor
        public static Color? GetColumnHeaderPanelShadowColor(DataGrid dataGrid)
        {
            return (Color?)dataGrid.GetValue(ColumnHeaderPanelShadowColorProperty);
        }

        public static void SetColumnHeaderPanelShadowColor(DataGrid dataGrid, Color? value)
        {
            dataGrid.SetValue(ColumnHeaderPanelShadowColorProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderPanelShadowColorProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderPanelShadowColor", typeof(Color?), typeof(DataGridHelper));
        #endregion

        #region ColumnHeaderPanelSeparatorBrush
        public static Brush GetColumnHeaderPanelSeparatorBrush(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(ColumnHeaderPanelSeparatorBrushProperty);
        }

        public static void SetColumnHeaderPanelSeparatorBrush(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(ColumnHeaderPanelSeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderPanelSeparatorBrushProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderPanelSeparatorBrush", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region ColumnHeaderPanelSeparatorVisibility
        public static Visibility GetColumnHeaderPanelSeparatorVisibility(DataGrid dataGrid)
        {
            return (Visibility)dataGrid.GetValue(ColumnHeaderPanelSeparatorVisibilityProperty);
        }

        public static void SetColumnHeaderPanelSeparatorVisibility(DataGrid dataGrid, Visibility value)
        {
            dataGrid.SetValue(ColumnHeaderPanelSeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderPanelSeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderPanelSeparatorVisibility", typeof(Visibility), typeof(DataGridHelper));
        #endregion

        #region ColumnHeaderHorizontalContentAlignment
        public static HorizontalAlignment GetColumnHeaderHorizontalContentAlignment(DataGrid dataGrid)
        {
            return (HorizontalAlignment)dataGrid.GetValue(ColumnHeaderHorizontalContentAlignmentProperty);
        }

        public static void SetColumnHeaderHorizontalContentAlignment(DataGrid dataGrid, HorizontalAlignment value)
        {
            dataGrid.SetValue(ColumnHeaderHorizontalContentAlignmentProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderHorizontalContentAlignmentProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderHorizontalContentAlignment", typeof(HorizontalAlignment), typeof(DataGridHelper));
        #endregion

        #region ColumnHeaderVerticalContentAlignment
        public static VerticalAlignment GetColumnHeaderVerticalContentAlignment(DataGrid dataGrid)
        {
            return (VerticalAlignment)dataGrid.GetValue(ColumnHeaderVerticalContentAlignmentProperty);
        }

        public static void SetColumnHeaderVerticalContentAlignment(DataGrid dataGrid, VerticalAlignment value)
        {
            dataGrid.SetValue(ColumnHeaderVerticalContentAlignmentProperty, value);
        }

        public static readonly DependencyProperty ColumnHeaderVerticalContentAlignmentProperty =
            DependencyProperty.RegisterAttached("ColumnHeaderVerticalContentAlignment", typeof(VerticalAlignment), typeof(DataGridHelper));
        #endregion

        #region UnitHoverBackground
        public static Brush GetUnitHoverBackground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(UnitHoverBackgroundProperty);
        }

        public static void SetUnitHoverBackground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(UnitHoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty UnitHoverBackgroundProperty =
            DependencyProperty.RegisterAttached("UnitHoverBackground", typeof(Brush), typeof(DataGridHelper));


        #endregion

        #region UnitHoverForeground
        public static Brush GetUnitHoverForeground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(UnitHoverForegroundProperty);
        }

        public static void SetUnitHoverForeground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(UnitHoverForegroundProperty, value);
        }

        public static readonly DependencyProperty UnitHoverForegroundProperty =
            DependencyProperty.RegisterAttached("UnitHoverForeground", typeof(Brush), typeof(DataGridHelper));


        #endregion

        #region UnitSelectedBackground
        public static Brush GetUnitSelectedBackground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(UnitSelectedBackgroundProperty);
        }

        public static void SetUnitSelectedBackground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(UnitSelectedBackgroundProperty, value);
        }

        public static readonly DependencyProperty UnitSelectedBackgroundProperty =
            DependencyProperty.RegisterAttached("UnitSelectedBackground", typeof(Brush), typeof(DataGridHelper));


        #endregion

        #region UnitSelectedForeground
        public static Brush GetUnitSelectedForeground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(UnitSelectedForegroundProperty);
        }

        public static void SetUnitSelectedForeground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(UnitSelectedForegroundProperty, value);
        }

        public static readonly DependencyProperty UnitSelectedForegroundProperty =
            DependencyProperty.RegisterAttached("UnitSelectedForeground", typeof(Brush), typeof(DataGridHelper));


        #endregion

        #region RowHeader Properties

        #region RowHeaderSeparatorBrush
        public static Brush GetRowHeaderSeparatorBrush(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(RowHeaderSeparatorBrushProperty);
        }

        public static void SetRowHeaderSeparatorBrush(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(RowHeaderSeparatorBrushProperty, value);
        }

        public static readonly DependencyProperty RowHeaderSeparatorBrushProperty =
            DependencyProperty.RegisterAttached("RowHeaderSeparatorBrush", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region RowHeaderSeparatorVisibility
        public static Visibility GetRowHeaderSeparatorVisibility(DataGrid dataGrid)
        {
            return (Visibility)dataGrid.GetValue(RowHeaderSeparatorVisibilityProperty);
        }

        public static void SetRowHeaderSeparatorVisibility(DataGrid dataGrid, Visibility value)
        {
            dataGrid.SetValue(RowHeaderSeparatorVisibilityProperty, value);
        }

        public static readonly DependencyProperty RowHeaderSeparatorVisibilityProperty =
            DependencyProperty.RegisterAttached("RowHeaderSeparatorVisibility", typeof(Visibility), typeof(DataGridHelper), new PropertyMetadata(Visibility.Visible));
        #endregion

        #region RowHeaderForeground
        public static Brush GetRowHeaderForeground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(RowHeaderForegroundProperty);
        }

        public static void SetRowHeaderForeground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(RowHeaderForegroundProperty, value);
        }

        public static readonly DependencyProperty RowHeaderForegroundProperty =
            DependencyProperty.RegisterAttached("RowHeaderForeground", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region RowHeaderBackground
        public static Brush GetRowHeaderBackground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(RowHeaderBackgroundProperty);
        }

        public static void SetRowHeaderBackground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(RowHeaderBackgroundProperty, value);
        }

        public static readonly DependencyProperty RowHeaderBackgroundProperty =
            DependencyProperty.RegisterAttached("RowHeaderBackground", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region RowHeaderBorderBrush
        public static Brush GetRowHeaderBorderBrush(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(RowHeaderBorderBrushProperty);
        }

        public static void SetRowHeaderBorderBrush(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(RowHeaderBorderBrushProperty, value);
        }

        public static readonly DependencyProperty RowHeaderBorderBrushProperty =
            DependencyProperty.RegisterAttached("RowHeaderBorderBrush", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region RowHeaderBorderThickness
        public static Thickness GetRowHeaderBorderThickness(DataGrid dataGrid)
        {
            return (Thickness)dataGrid.GetValue(RowHeaderBorderThicknessProperty);
        }

        public static void SetRowHeaderBorderThickness(DataGrid dataGrid, Thickness value)
        {
            dataGrid.SetValue(RowHeaderBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty RowHeaderBorderThicknessProperty =
            DependencyProperty.RegisterAttached("RowHeaderBorderThickness", typeof(Thickness), typeof(DataGridHelper));
        #endregion

        #region RowHeaderHoverForeground
        public static Brush GetRowHeaderHoverForeground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(RowHeaderHoverForegroundProperty);
        }

        public static void SetRowHeaderHoverForeground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(RowHeaderHoverForegroundProperty, value);
        }

        public static readonly DependencyProperty RowHeaderHoverForegroundProperty =
            DependencyProperty.RegisterAttached("RowHeaderHoverForeground", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region RowHeaderHoverBackground
        public static Brush GetRowHeaderHoverBackground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(RowHeaderHoverBackgroundProperty);
        }

        public static void SetRowHeaderHoverBackground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(RowHeaderHoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty RowHeaderHoverBackgroundProperty =
            DependencyProperty.RegisterAttached("RowHeaderHoverBackground", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region RowHeaderHoverBorderBrush
        public static Brush GetRowHeaderHoverBorderBrush(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(RowHeaderHoverBorderBrushProperty);
        }

        public static void SetRowHeaderHoverBorderBrush(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(RowHeaderHoverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty RowHeaderHoverBorderBrushProperty =
            DependencyProperty.RegisterAttached("RowHeaderHoverBorderBrush", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region RowHeaderHoverBorderThickness
        public static Thickness GetRowHeaderHoverBorderThickness(DataGrid dataGrid)
        {
            return (Thickness)dataGrid.GetValue(RowHeaderHoverBorderThicknessProperty);
        }

        public static void SetRowHeaderHoverBorderThickness(DataGrid dataGrid, Thickness value)
        {
            dataGrid.SetValue(RowHeaderHoverBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty RowHeaderHoverBorderThicknessProperty =
            DependencyProperty.RegisterAttached("RowHeaderHoverBorderThickness", typeof(Thickness), typeof(DataGridHelper));
        #endregion

        #region RowHeaderClickForeground
        public static Brush GetRowHeaderClickForeground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(RowHeaderClickForegroundProperty);
        }

        public static void SetRowHeaderClickForeground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(RowHeaderClickForegroundProperty, value);
        }

        public static readonly DependencyProperty RowHeaderClickForegroundProperty =
            DependencyProperty.RegisterAttached("RowHeaderClickForeground", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region RowHeaderClickBackground
        public static Brush GetRowHeaderClickBackground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(RowHeaderClickBackgroundProperty);
        }

        public static void SetRowHeaderClickBackground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(RowHeaderClickBackgroundProperty, value);
        }

        public static readonly DependencyProperty RowHeaderClickBackgroundProperty =
            DependencyProperty.RegisterAttached("RowHeaderClickBackground", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region RowHeaderClickBorderBrush
        public static Brush GetRowHeaderClickBorderBrush(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(RowHeaderClickBorderBrushProperty);
        }

        public static void SetRowHeaderClickBorderBrush(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(RowHeaderClickBorderBrushProperty, value);
        }

        public static readonly DependencyProperty RowHeaderClickBorderBrushProperty =
            DependencyProperty.RegisterAttached("RowHeaderClickBorderBrush", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region RowHeaderClickBorderThickness
        public static Thickness GetRowHeaderClickBorderThickness(DataGrid dataGrid)
        {
            return (Thickness)dataGrid.GetValue(RowHeaderClickBorderThicknessProperty);
        }

        public static void SetRowHeaderClickBorderThickness(DataGrid dataGrid, Thickness value)
        {
            dataGrid.SetValue(RowHeaderClickBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty RowHeaderClickBorderThicknessProperty =
            DependencyProperty.RegisterAttached("RowHeaderClickBorderThickness", typeof(Thickness), typeof(DataGridHelper));
        #endregion

        #endregion

        #region CellPadding
        public static Thickness GetCellPadding(DataGrid dataGrid)
        {
            return (Thickness)dataGrid.GetValue(CellPaddingProperty);
        }

        public static void SetCellPadding(DataGrid dataGrid, Thickness value)
        {
            dataGrid.SetValue(CellPaddingProperty, value);
        }

        public static readonly DependencyProperty CellPaddingProperty =
            DependencyProperty.RegisterAttached("CellPadding", typeof(Thickness), typeof(DataGridHelper));
        #endregion

        #region CellFocusedBackground
        public static Brush GetCellFocusedBackground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(CellFocusedBackgroundProperty);
        }

        public static void SetCellFocusedBackground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(CellFocusedBackgroundProperty, value);
        }

        public static readonly DependencyProperty CellFocusedBackgroundProperty =
            DependencyProperty.RegisterAttached("CellFocusedBackground", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region CellFocusedBorderBrush
        public static Brush GetCellFocusedBorderBrush(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(CellFocusedBorderBrushProperty);
        }

        public static void SetCellFocusedBorderBrush(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(CellFocusedBorderBrushProperty, value);
        }

        public static readonly DependencyProperty CellFocusedBorderBrushProperty =
            DependencyProperty.RegisterAttached("CellFocusedBorderBrush", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region CellFocusedBorderThickness
        public static Thickness? GetCellFocusedBorderThickness(DataGrid dataGrid)
        {
            return (Thickness?)dataGrid.GetValue(CellFocusedBorderThicknessProperty);
        }

        public static void SetCellFocusedBorderThickness(DataGrid dataGrid, Thickness? value)
        {
            dataGrid.SetValue(CellFocusedBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty CellFocusedBorderThicknessProperty =
            DependencyProperty.RegisterAttached("CellFocusedBorderThickness", typeof(Thickness?), typeof(DataGridHelper));
        #endregion

        #region CellFocusedForeground
        public static Brush GetCellFocusedForeground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(CellFocusedForegroundProperty);
        }

        public static void SetCellFocusedForeground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(CellFocusedForegroundProperty, value);
        }

        public static readonly DependencyProperty CellFocusedForegroundProperty =
            DependencyProperty.RegisterAttached("CellFocusedForeground", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region CellReadOnlyBackground
        public static Brush GetCellReadOnlyBackground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(CellReadOnlyBackgroundProperty);
        }

        public static void SetCellReadOnlyBackground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(CellReadOnlyBackgroundProperty, value);
        }

        public static readonly DependencyProperty CellReadOnlyBackgroundProperty =
            DependencyProperty.RegisterAttached("CellReadOnlyBackground", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region CellReadOnlyBorderBrush
        public static Brush GetCellReadOnlyBorderBrush(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(CellReadOnlyBorderBrushProperty);
        }

        public static void SetCellReadOnlyBorderBrush(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(CellReadOnlyBorderBrushProperty, value);
        }

        public static readonly DependencyProperty CellReadOnlyBorderBrushProperty =
            DependencyProperty.RegisterAttached("CellReadOnlyBorderBrush", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region CellReadOnlyBorderThickness
        public static Thickness? GetCellReadOnlyBorderThickness(DataGrid dataGrid)
        {
            return (Thickness?)dataGrid.GetValue(CellReadOnlyBorderThicknessProperty);
        }

        public static void SetCellReadOnlyBorderThickness(DataGrid dataGrid, Thickness? value)
        {
            dataGrid.SetValue(CellReadOnlyBorderThicknessProperty, value);
        }

        public static readonly DependencyProperty CellReadOnlyBorderThicknessProperty =
            DependencyProperty.RegisterAttached("CellReadOnlyBorderThickness", typeof(Thickness?), typeof(DataGridHelper));
        #endregion

        #region CellReadOnlyForeground
        public static Brush GetCellReadOnlyForeground(DataGrid dataGrid)
        {
            return (Brush)dataGrid.GetValue(CellReadOnlyForegroundProperty);
        }

        public static void SetCellReadOnlyForeground(DataGrid dataGrid, Brush value)
        {
            dataGrid.SetValue(CellReadOnlyForegroundProperty, value);
        }

        public static readonly DependencyProperty CellReadOnlyForegroundProperty =
            DependencyProperty.RegisterAttached("CellReadOnlyForeground", typeof(Brush), typeof(DataGridHelper));
        #endregion

        #region SelectedItems
        public static IList GetSelectedItems(DataGrid dataGrid)
        {
            return dataGrid.SelectedItems;
        }

        public static void SetSelectedItems(DataGrid dataGrid, IList value)
        {
            throw new Exception("DataGridHelper.SelectedItems is a read-only property.");
        }

        public static readonly DependencyProperty SelectedItemsProperty =
            DependencyProperty.RegisterAttached("SelectedItems", typeof(IList), typeof(DataGridHelper));
        #endregion

        #region AutoGeneratedCheckBoxStyle
        public static Style GetAutoGeneratedCheckBoxStyle(DataGrid dataGrid)
        {
            return (Style)dataGrid.GetValue(AutoGeneratedCheckBoxStyleProperty);
        }

        public static void SetAutoGeneratedCheckBoxStyle(DataGrid dataGrid, Style value)
        {
            dataGrid.SetValue(AutoGeneratedCheckBoxStyleProperty, value);
        }

        public static readonly DependencyProperty AutoGeneratedCheckBoxStyleProperty =
            DependencyProperty.RegisterAttached("AutoGeneratedCheckBoxStyle", typeof(Style), typeof(DataGridHelper));

        #endregion

        #region AutoGeneratedTextBoxStyle
        public static Style GetAutoGeneratedTextBoxStyle(DataGrid dataGrid)
        {
            return (Style)dataGrid.GetValue(AutoGeneratedTextBoxStyleProperty);
        }

        public static void SetAutoGeneratedTextBoxStyle(DataGrid dataGrid, Style value)
        {
            dataGrid.SetValue(AutoGeneratedTextBoxStyleProperty, value);
        }

        public static readonly DependencyProperty AutoGeneratedTextBoxStyleProperty =
            DependencyProperty.RegisterAttached("AutoGeneratedTextBoxStyle", typeof(Style), typeof(DataGridHelper));
        #endregion

        #region AutoGeneratedComboBoxStyle
        public static Style GetAutoGeneratedComboBoxStyle(DataGrid dataGrid)
        {
            return (Style)dataGrid.GetValue(AutoGeneratedComboBoxStyleProperty);
        }

        public static void SetAutoGeneratedComboBoxStyle(DataGrid dataGrid, Style value)
        {
            dataGrid.SetValue(AutoGeneratedComboBoxStyleProperty, value);
        }

        public static readonly DependencyProperty AutoGeneratedComboBoxStyleProperty =
            DependencyProperty.RegisterAttached("AutoGeneratedComboBoxStyle", typeof(Style), typeof(DataGridHelper));
        #endregion

        #region RowIndex
        public static int GetRowIndex(DataGridRow dataGridRow)
        {
            return (int)dataGridRow.GetValue(RowIndexProperty);
        }

        public static void SetRowIndex(DataGridRow dataGridRow, int value)
        {
            throw new Exception("DataGridHelper.RowIndex is a read-only property.");
        }

        public static readonly DependencyProperty RowIndexProperty =
            DependencyProperty.RegisterAttached("RowIndex", typeof(int), typeof(DataGridHelper));
        #endregion

        #region ColumnsSequence
        public static IList<string> GetColumnsSequence(DataGrid dataGrid)
        {
            return (IList<string>)dataGrid.GetValue(ColumnsSequenceProperty);
        }

        public static void SetColumnsSequence(DataGrid dataGrid, IList<string> value)
        {
            dataGrid.SetValue(ColumnsSequenceProperty, value);
        }

        public static readonly DependencyProperty ColumnsSequenceProperty =
            DependencyProperty.RegisterAttached("ColumnsSequence", typeof(IList<string>), typeof(DataGridHelper), new PropertyMetadata(OnColumnsSequenceChanged));

        #endregion

        #region ColumnPropertyPath
        public static string GetColumnPropertyPath(DataGridColumn column)
        {
            return (string)column.GetValue(ColumnPropertyPathProperty);
        }

        public static void SetColumnPropertyPath(DataGridColumn column, string value)
        {
            column.SetValue(ColumnPropertyPathProperty, value);
        }

        public static readonly DependencyProperty ColumnPropertyPathProperty =
            DependencyProperty.RegisterAttached("ColumnPropertyPath", typeof(string), typeof(DataGridHelper));
        #endregion

        #region AutoGeneratedColumns
        public static Dictionary<string, DataGridColumn> GetAutoGeneratedColumns(DataGrid dataGrid)
        {
            return (Dictionary<string, DataGridColumn>)dataGrid.GetValue(AutoGeneratedColumnsProperty);
        }

        public static void SetAutoGeneratedColumns(DataGrid dataGrid, Dictionary<string, DataGridColumn> value)
        {
            dataGrid.SetValue(AutoGeneratedColumnsProperty, value);
        }

        public static readonly DependencyProperty AutoGeneratedColumnsProperty =
            DependencyProperty.RegisterAttached("AutoGeneratedColumns", typeof(Dictionary<string, DataGridColumn>), typeof(DataGridHelper));
        #endregion


        #endregion

        #region Routed Events

        #region RowClick
        public static void AddRowClickHandler(UIElement element, RoutedEventHandler handler)
        {
            element.AddHandler(RowClickEvent, handler);
        }

        public static void RemoveRowClickHandler(UIElement element, RoutedEventHandler handler)
        {
            element.RemoveHandler(RowClickEvent, handler);
        }

        public static readonly RoutedEvent RowClickEvent
            = EventManager.RegisterRoutedEvent("RowClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(DataGridHelper));
        #endregion

        #region RowDoubleClick
        public static void AddRowDoubleClickHandler(UIElement element, RoutedEventHandler handler)
        {
            element.AddHandler(RowDoubleClickEvent, handler);
        }

        public static void RemoveRowDoubleClickHandler(UIElement element, RoutedEventHandler handler)
        {
            element.RemoveHandler(RowDoubleClickEvent, handler);
        }

        public static readonly RoutedEvent RowDoubleClickEvent
            = EventManager.RegisterRoutedEvent("RowDoubleClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(DataGridHelper));
        #endregion

        #endregion

        #region Methods
        public static void SortColumn(DataGrid dataGrid, string propertyName, ListSortDirection direction)
        {
            var dictionary = GetAutoGeneratedColumns(dataGrid);
            if (dictionary.ContainsKey(propertyName))
            {
                var column = dictionary[propertyName];
                column.SortDirection = direction;
                return;
            }
            throw new Exception($"The column named {propertyName} could not be found in the auto-generated columns.");
        }
        #endregion

        #region Internal Properties

        #region Hook
        internal static bool GetHook(DataGrid dataGrid)
        {
            return (bool)dataGrid.GetValue(HookProperty);
        }

        internal static void SetHook(DataGrid dataGrid, bool value)
        {
            dataGrid.SetValue(HookProperty, value);
        }

        internal static readonly DependencyProperty HookProperty =
            DependencyProperty.RegisterAttached("Hook", typeof(bool), typeof(DataGridHelper), new PropertyMetadata(OnHookChanged));
        #endregion

        #region RowHeaderHook
        internal static bool GetRowHeaderHook(DataGridRowHeader dataGridRowHeader)
        {
            return (bool)dataGridRowHeader.GetValue(RowHeaderHookProperty);
        }

        internal static void SetRowHeaderHook(DataGridRowHeader dataGridRowHeader, bool value)
        {
            dataGridRowHeader.SetValue(RowHeaderHookProperty, value);
        }

        internal static readonly DependencyProperty RowHeaderHookProperty =
            DependencyProperty.RegisterAttached("RowHeaderHook", typeof(bool), typeof(DataGridHelper), new PropertyMetadata(OnRowHeaderHookChanged));
        #endregion

        #region IsRowHeaderPressed
        internal static bool GetIsRowHeaderPressed(DataGridRowHeader dataGridRowHeader)
        {
            return (bool)dataGridRowHeader.GetValue(IsRowHeaderPressedProperty);
        }

        internal static void SetIsRowHeaderPressed(DataGridRowHeader dataGridRowHeader, bool value)
        {
            dataGridRowHeader.SetValue(IsRowHeaderPressedProperty, value);
        }

        internal static readonly DependencyProperty IsRowHeaderPressedProperty =
            DependencyProperty.RegisterAttached("IsRowHeaderPressed", typeof(bool), typeof(DataGridHelper));
        #endregion

        #region RowHook
        internal static bool GetRowHook(DataGridRow dataGridRow)
        {
            return (bool)dataGridRow.GetValue(RowHookProperty);
        }

        internal static void SetRowHook(DataGridRow dataGridRow, bool value)
        {
            dataGridRow.SetValue(RowHookProperty, value);
        }

        internal static readonly DependencyProperty RowHookProperty =
            DependencyProperty.RegisterAttached("RowHook", typeof(bool), typeof(DataGridHelper), new PropertyMetadata(OnRowHookChanged));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnHookChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var dataGrid = (DataGrid)d;
            dataGrid.AutoGeneratingColumn -= DataGrid_AutoGeneratingColumn;
            dataGrid.AutoGeneratedColumns -= DataGrid_AutoGeneratedColumns;
            dataGrid.LoadingRow -= DataGrid_LoadingRow;

            if ((bool)e.NewValue)
            {
                dataGrid.AutoGeneratingColumn += DataGrid_AutoGeneratingColumn;
                dataGrid.AutoGeneratedColumns += DataGrid_AutoGeneratedColumns;
                dataGrid.LoadingRow += DataGrid_LoadingRow;
                dataGrid.SetValue(SelectedItemsProperty, dataGrid.SelectedItems);
            }
        }

        private static void DataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.SetValue(RowIndexProperty, e.Row.GetIndex() + 1);
        }

        private static void OnColumnsSequenceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var dataGrid = (DataGrid)d;
            var columnSequence = GetColumnsSequence(dataGrid);
            if (columnSequence != null)
            {
                foreach (var column in dataGrid.Columns)
                {
                    var propertyPath = GetColumnPropertyPath(column);
                    column.Visibility = (string.IsNullOrEmpty(propertyPath) || columnSequence.Contains(propertyPath))
                                          ? Visibility.Visible
                                          : Visibility.Collapsed;
                }
            }
        }

        private static void OnRowHeaderHookChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var rowHeader = (DataGridRowHeader)d;
            rowHeader.MouseLeave -= RowHeader_MouseLeave;
            rowHeader.PreviewMouseUp -= RowHeader_MouseUp;
            rowHeader.PreviewMouseDown -= RowHeader_MouseDown;
            if ((bool)e.NewValue)
            {
                rowHeader.MouseLeave += RowHeader_MouseLeave;
                rowHeader.PreviewMouseUp += RowHeader_MouseUp;
                rowHeader.PreviewMouseDown += RowHeader_MouseDown;
            }
        }

        private static void RowHeader_MouseLeave(object sender, MouseEventArgs e)
        {
            SetIsRowHeaderPressed(sender as DataGridRowHeader, false);
        }

        private static void RowHeader_MouseUp(object sender, MouseButtonEventArgs e)
        {
            SetIsRowHeaderPressed(sender as DataGridRowHeader, false);
        }

        private static void RowHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SetIsRowHeaderPressed(sender as DataGridRowHeader, true);
        }

        private static void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            var dataGrid = (DataGrid)sender;

            var dictionary = GetAutoGeneratedColumns(dataGrid);
            if (dictionary == null)
            {
                dictionary = new Dictionary<string, DataGridColumn>();
                SetAutoGeneratedColumns(dataGrid, dictionary);
            }

            var descriptor = (PropertyDescriptor)e.PropertyDescriptor;
            var propertyInfo = descriptor.ComponentType.GetProperty(descriptor.Name);
            var attributes = propertyInfo.GetCustomAttributes(true);
            var ignoreAttribute = attributes.FirstOrDefault(x => x.GetType() == typeof(ColumnIgnoreAttribute));
            if (ignoreAttribute != null)
            {
                e.Cancel = true;
                return;
            }

            var cellAttribute = attributes.OfType<ColumnCellAttribute>().FirstOrDefault();
            var bindingAttribute = attributes.OfType<ColumnBindingAttribute>().FirstOrDefault();
            var comboAttribute = attributes.OfType<ColumnComboAttribute>().FirstOrDefault();

            if (comboAttribute != null)
            {
                e.Column = new DataGridComboBoxColumn()
                {
                    CanUserReorder = e.Column.CanUserReorder,
                    CanUserSort = e.Column.CanUserSort,
                    CanUserResize = e.Column.CanUserResize,
                    DragIndicatorStyle = e.Column.DragIndicatorStyle,
                    Header = e.Column.Header,
                    HeaderStringFormat = e.Column.HeaderStringFormat,
                    IsReadOnly = e.Column.IsReadOnly,
                    MaxWidth = e.Column.MaxWidth,
                    MinWidth = e.Column.MinWidth,
                    SortDirection = e.Column.SortDirection,
                    SortMemberPath = e.Column.SortMemberPath,
                    Visibility = e.Column.Visibility,
                    Width = e.Column.Width,
                };
            }
            if (attributes.OfType<ColumnTemplateAttribute>().FirstOrDefault() is ColumnTemplateAttribute templateAttribute)
            {
                
                var cellTemplate = templateAttribute.CellTemplateKey == null ? CreateDefaultTemplate(descriptor.Name, bindingAttribute) : (DataTemplate)dataGrid.FindResource(templateAttribute.CellTemplateKey);
                var cellEditingTemplate = templateAttribute.CellEditingTemplateKey == CreateDefaultEditingTemplate(GetAutoGeneratedTextBoxStyle(dataGrid), descriptor.Name, bindingAttribute) ? null : (DataTemplate)dataGrid.FindResource(templateAttribute.CellEditingTemplateKey);

                e.Column = new DataGridTemplateColumn()
                {
                    CanUserReorder = e.Column.CanUserReorder,
                    CanUserSort = e.Column.CanUserSort,
                    CanUserResize = e.Column.CanUserResize,
                    DragIndicatorStyle = e.Column.DragIndicatorStyle,
                    Header = e.Column.Header,
                    HeaderStringFormat = e.Column.HeaderStringFormat,
                    IsReadOnly = e.Column.IsReadOnly,
                    MaxWidth = e.Column.MaxWidth,
                    MinWidth = e.Column.MinWidth,
                    SortDirection = e.Column.SortDirection,
                    SortMemberPath = e.Column.SortMemberPath,
                    Visibility = e.Column.Visibility,
                    Width = e.Column.Width,
                    CellTemplate = cellTemplate,
                    CellEditingTemplate = cellEditingTemplate,
                };
            }

            if (e.Column is DataGridTextColumn textColumn)
            {
                var elementStyle = new Style(typeof(TextBlock))
                {
                    BasedOn = cellAttribute?.ElementStyleKey == null ? textColumn.ElementStyle : (Style)dataGrid.FindResource(cellAttribute.ElementStyleKey)
                };
                if (cellAttribute?.ElementStyleKey == null)
                {
                    elementStyle.Setters.Add(new Setter(TextBlock.VerticalAlignmentProperty, VerticalAlignment.Center));
                    elementStyle.Setters.Add(new Setter(TextBlock.HorizontalAlignmentProperty, new Binding()
                    {
                        Path = new PropertyPath(DataGrid.HorizontalContentAlignmentProperty),
                        Source = dataGrid,
                    }));
                }
                textColumn.ElementStyle = elementStyle;

                var autoGeneratedTextBoxStyle = GetAutoGeneratedTextBoxStyle(dataGrid);
                var editingElementStyle = new Style(typeof(TextBox))
                {
                    BasedOn = cellAttribute?.EditingElementStyleKey == null ? (autoGeneratedTextBoxStyle ?? textColumn.EditingElementStyle) : (Style)dataGrid.FindResource(cellAttribute.EditingElementStyleKey)
                };
                if (cellAttribute?.EditingElementStyleKey == null && autoGeneratedTextBoxStyle == null)
                {
                    editingElementStyle.Setters.Add(new Setter(TextBox.VerticalContentAlignmentProperty, VerticalAlignment.Center));
                    editingElementStyle.Setters.Add(new Setter(TextBox.HorizontalContentAlignmentProperty, new Binding()
                    {
                        Path = new PropertyPath(DataGrid.HorizontalContentAlignmentProperty),
                        Source = dataGrid,
                    }));
                }
                textColumn.EditingElementStyle = editingElementStyle;

                if (bindingAttribute != null && textColumn.Binding is Binding binding)
                {
                    if (bindingAttribute.BindingMode != null)
                    {
                        binding.Mode = (BindingMode)bindingAttribute.BindingMode;
                    }
                    if (bindingAttribute.UpdateSourceTrigger != null)
                    {
                        binding.UpdateSourceTrigger = (UpdateSourceTrigger)bindingAttribute.UpdateSourceTrigger;
                    }
                    if (bindingAttribute.ConverterType != null)
                    {
                        binding.Converter = Activator.CreateInstance(bindingAttribute.ConverterType) as IValueConverter;
                    }
                    if (bindingAttribute.ConverterParameter != null)
                    {
                        binding.ConverterParameter = bindingAttribute.ConverterParameter;
                    }
                    if (bindingAttribute.StringFormat != null)
                    {
                        binding.StringFormat = bindingAttribute.StringFormat;
                    }
                }
            }
            else if (e.Column is DataGridComboBoxColumn comboColumn)
            {
                var elementStyle = new Style(typeof(ComboBox))
                {
                    BasedOn = cellAttribute?.ElementStyleKey == null ? comboColumn.ElementStyle : (Style)dataGrid.FindResource(StyleKeys.DataGridComboBoxStyle)
                };
                if (cellAttribute?.ElementStyleKey == null)
                {
                    elementStyle.Setters.Add(new Setter(ComboBox.VerticalContentAlignmentProperty, VerticalAlignment.Center));
                    elementStyle.Setters.Add(new Setter(ComboBox.HorizontalContentAlignmentProperty, new Binding()
                    {
                        Path = new PropertyPath(DataGrid.HorizontalContentAlignmentProperty),
                        Source = dataGrid,
                    }));
                }

                var autoGeneratedComboBoxStyle = GetAutoGeneratedComboBoxStyle(dataGrid);
                var editingElementStyle = new Style(typeof(ComboBox))
                {
                    BasedOn = cellAttribute?.EditingElementStyleKey == null ? (autoGeneratedComboBoxStyle ?? comboColumn.EditingElementStyle) : (Style)dataGrid.FindResource(cellAttribute.EditingElementStyleKey)
                };
                if (cellAttribute?.EditingElementStyleKey == null && autoGeneratedComboBoxStyle == null)
                {
                    editingElementStyle.Setters.Add(new Setter(ComboBox.VerticalContentAlignmentProperty, VerticalAlignment.Center));
                    editingElementStyle.Setters.Add(new Setter(ComboBox.HorizontalContentAlignmentProperty, new Binding()
                    {
                        Path = new PropertyPath(DataGrid.HorizontalContentAlignmentProperty),
                        Source = dataGrid,
                    }));
                }

                if (comboAttribute != null)
                {
                    if (comboAttribute.ItemsSourceBindingPath != null)
                    {
                        elementStyle.Setters.Add(new Setter(ComboBox.ItemsSourceProperty, new Binding()
                        {
                            Path = new PropertyPath(comboAttribute.ItemsSourceBindingPath),
                        }));
                        editingElementStyle.Setters.Add(new Setter(ComboBox.ItemsSourceProperty, new Binding()
                        {
                            Path = new PropertyPath(comboAttribute.ItemsSourceBindingPath),
                        }));
                    }
                    if (comboAttribute.DisplayMemberPath != null)
                    {
                        comboColumn.DisplayMemberPath = comboAttribute.DisplayMemberPath;
                    }
                    if (comboAttribute.SelectedValuePath != null)
                    {
                        comboColumn.SelectedValuePath = comboAttribute.SelectedValuePath;
                        comboColumn.SelectedValueBinding = new Binding(e.PropertyName);
                    }
                    else
                    {
                        comboColumn.SelectedItemBinding = new Binding(e.PropertyName);
                    }
                }

                comboColumn.ElementStyle = elementStyle;
                comboColumn.EditingElementStyle = editingElementStyle;

                if (bindingAttribute != null && (propertyInfo.PropertyType.IsEnum ? comboColumn.SelectedValueBinding : comboColumn.SelectedItemBinding) is Binding binding)
                {
                    if (bindingAttribute.BindingMode != null)
                    {
                        binding.Mode = (BindingMode)bindingAttribute.BindingMode;
                    }
                    if (bindingAttribute.UpdateSourceTrigger != null)
                    {
                        binding.UpdateSourceTrigger = (UpdateSourceTrigger)bindingAttribute.UpdateSourceTrigger;
                    }
                    if (bindingAttribute.ConverterType != null)
                    {
                        binding.Converter = Activator.CreateInstance(bindingAttribute.ConverterType) as IValueConverter;
                    }
                    if (bindingAttribute.ConverterParameter != null)
                    {
                        binding.ConverterParameter = bindingAttribute.ConverterParameter;
                    }
                    if (bindingAttribute.StringFormat != null)
                    {
                        binding.StringFormat = bindingAttribute.StringFormat;
                    }
                }

            }
            else if (e.Column is DataGridCheckBoxColumn checkBoxColumn)
            {
                var autoGeneratedCheckBoxStyle = GetAutoGeneratedCheckBoxStyle(dataGrid);
                var elementStyle = new Style(typeof(CheckBox))
                {
                    BasedOn = cellAttribute?.ElementStyleKey == null ? (autoGeneratedCheckBoxStyle ?? (Style)dataGrid.FindResource(typeof(CheckBox))) : (Style)dataGrid.FindResource(cellAttribute.ElementStyleKey)
                };
                if (cellAttribute?.ElementStyleKey == null)
                {
                    elementStyle.Setters.Add(new Setter(CheckBox.IsHitTestVisibleProperty, false));
                    elementStyle.Setters.Add(new Setter(CheckBox.IsEnabledProperty, false));
                    elementStyle.Setters.Add(new Setter(CheckBox.VerticalAlignmentProperty, VerticalAlignment.Center));
                    elementStyle.Setters.Add(new Setter(CheckBox.HorizontalAlignmentProperty, new Binding()
                    {
                        Path = new PropertyPath(DataGrid.HorizontalContentAlignmentProperty),
                        Source = dataGrid,
                    }));
                }
                checkBoxColumn.ElementStyle = elementStyle;

                var editingElementStyle = new Style(typeof(CheckBox))
                {
                    BasedOn = cellAttribute?.EditingElementStyleKey == null ? (autoGeneratedCheckBoxStyle ?? checkBoxColumn.EditingElementStyle) : (Style)dataGrid.FindResource(cellAttribute.EditingElementStyleKey)
                };
                if (cellAttribute?.EditingElementStyleKey == null && autoGeneratedCheckBoxStyle == null)
                {
                    editingElementStyle.Setters.Add(new Setter(CheckBox.VerticalAlignmentProperty, VerticalAlignment.Center));
                    editingElementStyle.Setters.Add(new Setter(CheckBox.HorizontalAlignmentProperty, new Binding()
                    {
                        Path = new PropertyPath(DataGrid.HorizontalContentAlignmentProperty),
                        Source = dataGrid,
                    }));
                }
                checkBoxColumn.EditingElementStyle = editingElementStyle;

                if (bindingAttribute != null && checkBoxColumn.Binding is Binding binding)
                {
                    if (bindingAttribute.BindingMode != null)
                    {
                        binding.Mode = (BindingMode)bindingAttribute.BindingMode;
                    }
                    if (bindingAttribute.UpdateSourceTrigger != null)
                    {
                        binding.UpdateSourceTrigger = (UpdateSourceTrigger)bindingAttribute.UpdateSourceTrigger;
                    }
                    if (bindingAttribute.ConverterType != null)
                    {
                        binding.Converter = Activator.CreateInstance(bindingAttribute.ConverterType) as IValueConverter;
                    }
                    if (bindingAttribute.ConverterParameter != null)
                    {
                        binding.ConverterParameter = bindingAttribute.ConverterParameter;
                    }
                    if (bindingAttribute.StringFormat != null)
                    {
                        binding.StringFormat = bindingAttribute.StringFormat;
                    }
                }

            }

            if (attributes.OfType<ColumnDisplayIndexAttribute>().FirstOrDefault() is ColumnDisplayIndexAttribute displayIndexAttribute)
            {
                e.Column.DisplayIndex = displayIndexAttribute.DisplayIndex;
            }
            if (attributes.OfType<ColumnHeaderAttribute>().FirstOrDefault() is ColumnHeaderAttribute columnHeaderAttribute)
            {
                e.Column.HeaderTemplate = columnHeaderAttribute.TemplateKey == null ? null : (DataTemplate)dataGrid.FindResource(columnHeaderAttribute.TemplateKey);
                if (columnHeaderAttribute.StringFormat != null)
                {
                    e.Column.HeaderStringFormat = columnHeaderAttribute.StringFormat;
                }
                if (columnHeaderAttribute.VerticalHeaderAlignment != null || columnHeaderAttribute.HorizontalHeaderAlignment != null)
                {
                    var headerStyle = new Style(typeof(DataGridColumnHeader))
                    {
                        BasedOn = e.Column.HeaderStyle ?? (Style)dataGrid.FindResource(Resources.StyleKeys.DataGridColumnHeaderStyle)
                    };
                    if (columnHeaderAttribute.VerticalHeaderAlignment != null)
                    {
                        headerStyle.Setters.Add(new Setter(DataGridColumnHeader.VerticalContentAlignmentProperty, columnHeaderAttribute.VerticalHeaderAlignment));
                    }
                    if (columnHeaderAttribute.HorizontalHeaderAlignment != null)
                    {
                        headerStyle.Setters.Add(new Setter(DataGridColumnHeader.HorizontalContentAlignmentProperty, columnHeaderAttribute.HorizontalHeaderAlignment));
                    }
                    e.Column.HeaderStyle = headerStyle;
                }
            }
            if (cellAttribute != null)
            {
                var cellStyle = new Style(typeof(DataGridCell))
                {
                    BasedOn = e.Column.CellStyle ?? dataGrid.FindResource(typeof(DataGridCell)) as Style,
                };

                if (cellAttribute.ForegroundBrushKey != null)
                {
                    var foreground = (Brush)dataGrid.FindResource(cellAttribute.ForegroundBrushKey);
                    cellStyle.Setters.Add(new Setter(DataGridCell.ForegroundProperty, foreground));
                }
                else if (cellAttribute.Foreground != null)
                {
                    if (ColorConverter.ConvertFromString(cellAttribute.Foreground) is Color color)
                    {
                        cellStyle.Setters.Add(new Setter(DataGridCell.ForegroundProperty, new SolidColorBrush(color)));
                    }
                }

                if (cellAttribute.BackgroundBrushKey != null)
                {
                    var background = (Brush)dataGrid.FindResource(cellAttribute.BackgroundBrushKey);
                    cellStyle.Setters.Add(new Setter(DataGridCell.BackgroundProperty, background));
                }
                else if (cellAttribute.Background != null)
                {
                    if (ColorConverter.ConvertFromString(cellAttribute.Background) is Color color)
                    {
                        cellStyle.Setters.Add(new Setter(DataGridCell.BackgroundProperty, new SolidColorBrush(color)));
                    }
                }

                if (cellAttribute.VerticalContentAlignment != null)
                {
                    cellStyle.Setters.Add(new Setter(DataGridCell.VerticalContentAlignmentProperty, cellAttribute.VerticalContentAlignment));
                }
                if (cellAttribute.HorizontalContentAlignment != null)
                {
                    cellStyle.Setters.Add(new Setter(DataGridCell.HorizontalContentAlignmentProperty, cellAttribute.HorizontalContentAlignment));
                }
                e.Column.CellStyle = cellStyle;
            }
            if (attributes.OfType<ReadOnlyAttribute>().FirstOrDefault() is ReadOnlyAttribute readOnlyAttribute)
            {
                e.Column.IsReadOnly = readOnlyAttribute.IsReadOnly;
            }
            if (attributes.OfType<DisplayNameAttribute>().FirstOrDefault() is DisplayNameAttribute displayNameAttribute)
            {
                e.Column.Header = displayNameAttribute.DisplayName;
            }
            if (attributes.OfType<ColumnWidthAttribute>().FirstOrDefault() is ColumnWidthAttribute columnWidthAttribute)
            {
                if (columnWidthAttribute.Width != null)
                {
                    e.Column.Width = GridLengthUtil.ConvertToDataGridLength(columnWidthAttribute.Width);
                }
                if (columnWidthAttribute.IsMaxWidthSet)
                {
                    e.Column.MaxWidth = (double)columnWidthAttribute.MaxWidth;
                }
                if (columnWidthAttribute.IsMinWidthSet)
                {
                    e.Column.MinWidth = (double)columnWidthAttribute.MinWidth;
                }
            }
            if (attributes.OfType<ColumnSortAttribute>().FirstOrDefault() is ColumnSortAttribute sortAttribute)
            {
                e.Column.CanUserSort = sortAttribute.CanUserSort;
                e.Column.SortDirection = sortAttribute.SortDirection;
                if (e.Column.SortMemberPath != null)
                {
                    e.Column.SortMemberPath = sortAttribute.SortMemberPath;
                }
            }
            if (attributes.OfType<ColumnResizeAttribute>().FirstOrDefault() is ColumnResizeAttribute resizeAttribute)
            {
                e.Column.CanUserResize = resizeAttribute.CanUserResize;
            }
            if (attributes.OfType<ColumnReorderAttribute>().FirstOrDefault() is ColumnReorderAttribute reorderAttribute)
            {
                e.Column.CanUserReorder = reorderAttribute.CanUserReorder;
            }

            if (dictionary.ContainsKey(e.PropertyName))
            {
                dictionary[e.PropertyName] = e.Column;
            }
            else
            {
                dictionary.Add(e.PropertyName, e.Column);
            }

            SetColumnPropertyPath(e.Column, e.PropertyName);
        }

        private static void DataGrid_AutoGeneratedColumns(object sender, EventArgs e)
        {
            var dataGrid = (DataGrid)sender;

            var setColumns = dataGrid.Columns.Where(x => x.DisplayIndex != -1).ToList();
            var unsetColumns = dataGrid.Columns.Where(x => x.DisplayIndex == -1).ToList();

            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                if (setColumns.FirstOrDefault(x => x.DisplayIndex == i) is DataGridColumn column)
                {
                    column.DisplayIndex = i;
                    setColumns.Remove(column);
                }
                else
                {
                    var targetColumn = unsetColumns.First();
                    targetColumn.DisplayIndex = i;
                    unsetColumns.Remove(targetColumn);
                }
            }

            var columnSequence = GetColumnsSequence(dataGrid);
            if (columnSequence != null)
            {
                foreach (var column in dataGrid.Columns)
                {
                    var propertyPath = GetColumnPropertyPath(column);
                    column.Visibility = (string.IsNullOrEmpty(propertyPath) || columnSequence.Contains(propertyPath))
                        ? Visibility.Visible 
                        : Visibility.Collapsed;
                }
            }

        }

        private static void OnRowHookChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var row = (DataGridRow)d;
            row.MouseDoubleClick -= DataGridRow_MouseDoubleClick;
            if ((bool)e.NewValue)
            {
                row.MouseDown += Row_MouseDown;
                row.PreviewMouseDown += Row_PreviewMouseDown;
                row.MouseDoubleClick += DataGridRow_MouseDoubleClick;
            }
        }

        private static void Row_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var row = sender as DataGridRow;
            var dataGrid = FrameworkElementUtil.FindVisualParent<DataGrid>(row);
            var selectediNDEX = dataGrid.SelectedIndex;
        }

        private static void Row_MouseDown(object sender, MouseButtonEventArgs e)
        {
        }

        private static void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = sender as DataGridRow;
            var dataGrid = FrameworkElementUtil.FindVisualParent<DataGrid>(row);
            if (dataGrid != null)
            {
                row.RaiseEvent(new RoutedEventArgs(RowDoubleClickEvent));
            }
        }

        #endregion

        #region Functions
        
        private static DataTemplate CreateDefaultTemplate(string propertyName, ColumnBindingAttribute bindingAttribute)
        {
            var textBlock = new FrameworkElementFactory(typeof(TextBlock));
            textBlock.SetValue(TextBlock.VerticalAlignmentProperty, VerticalAlignment.Center);
            
            var binding = new Binding()
            {
                Path = new PropertyPath(propertyName),
            };

            if (bindingAttribute != null)
            {
                if (bindingAttribute.UpdateSourceTrigger != null)
                {
                    binding.UpdateSourceTrigger = (UpdateSourceTrigger)bindingAttribute.UpdateSourceTrigger;
                }
                if (bindingAttribute.ConverterType != null)
                {
                    binding.Converter = Activator.CreateInstance(bindingAttribute.ConverterType) as IValueConverter;
                }
                if (bindingAttribute.ConverterParameter != null)
                {
                    binding.ConverterParameter = bindingAttribute.ConverterParameter;
                }
                if (bindingAttribute.StringFormat != null)
                {
                    binding.StringFormat = bindingAttribute.StringFormat;
                }
            }
            textBlock.SetBinding(TextBlock.TextProperty, binding);

            var template = new DataTemplate()
            {
                VisualTree = textBlock,
            };
            return template;
        }

        private static DataTemplate CreateDefaultEditingTemplate(Style textBoxStyle, string propertyName, ColumnBindingAttribute bindingAttribute)
        {
            var textBox = new FrameworkElementFactory(typeof(TextBox));
            textBox.SetValue(TextBox.StyleProperty, textBoxStyle);

            var binding = new Binding()
            {
                Path = new PropertyPath(propertyName),
            };

            if (bindingAttribute != null)
            {
                if (bindingAttribute.BindingMode != null)
                {
                    binding.Mode = (BindingMode)bindingAttribute.BindingMode;
                }
                if (bindingAttribute.UpdateSourceTrigger != null)
                {
                    binding.UpdateSourceTrigger = (UpdateSourceTrigger)bindingAttribute.UpdateSourceTrigger;
                }
                if (bindingAttribute.ConverterType != null)
                {
                    binding.Converter = Activator.CreateInstance(bindingAttribute.ConverterType) as IValueConverter;
                }
                if (bindingAttribute.ConverterParameter != null)
                {
                    binding.ConverterParameter = bindingAttribute.ConverterParameter;
                }
                if (bindingAttribute.StringFormat != null)
                {
                    binding.StringFormat = bindingAttribute.StringFormat;
                }
            }
            textBox.SetBinding(TextBlock.TextProperty, binding);

            var template = new DataTemplate()
            {
                VisualTree = textBox,
            };
            return template;
        }

        #endregion
    }
}
