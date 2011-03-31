﻿using System;
using System.Windows;
using System.Windows.Input;
using Microsoft.Windows.Controls.Primitives;

namespace Microsoft.Windows.Controls
{
    public class IntegerUpDown : UpDownBase<int?>
    {
        #region Properties

        #region DefaultValue

        //can possibly be in base class
        public static readonly DependencyProperty DefaultValueProperty = DependencyProperty.Register("DefaultValue", typeof(int), typeof(IntegerUpDown), new UIPropertyMetadata(default(int)));
        public int DefaultValue
        {
            get { return (int)GetValue(DefaultValueProperty); }
            set { SetValue(DefaultValueProperty, value); }
        }

        #endregion //DefaultValue

        #region FormatString

        public static readonly DependencyProperty FormatStringProperty = DependencyProperty.Register("FormatString", typeof(string), typeof(IntegerUpDown), new UIPropertyMetadata(String.Empty));
        public string FormatString
        {
            get { return (string)GetValue(FormatStringProperty); }
            set { SetValue(FormatStringProperty, value); }
        }        

        #endregion //FormatString

        #region Increment

        public static readonly DependencyProperty IncrementProperty = DependencyProperty.Register("Increment", typeof(int), typeof(IntegerUpDown), new PropertyMetadata(1));
        public int Increment
        {
            get { return (int)GetValue(IncrementProperty); }
            set { SetValue(IncrementProperty, value); }
        }

        #endregion

        #region Maximum

        public static readonly DependencyProperty MaximumProperty = DependencyProperty.Register("Maximum", typeof(int), typeof(IntegerUpDown), new UIPropertyMetadata(int.MaxValue, OnMaximumChanged));
        public int Maximum
        {
            get { return (int)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        private static void OnMaximumChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            IntegerUpDown integerUpDown = o as IntegerUpDown;
            if (integerUpDown != null)
                integerUpDown.OnMaximumChanged((int)e.OldValue, (int)e.NewValue);
        }

        protected virtual void OnMaximumChanged(int oldValue, int newValue)
        {
            //SetValidSpinDirection();
        }

        #endregion //Maximum

        #region Minimum

        public static readonly DependencyProperty MinimumProperty = DependencyProperty.Register("Minimum", typeof(int), typeof(IntegerUpDown), new UIPropertyMetadata(int.MinValue, OnMinimumChanged));
        public int Minimum
        {
            get { return (int)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        private static void OnMinimumChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            IntegerUpDown integerUpDown = o as IntegerUpDown;
            if (integerUpDown != null)
                integerUpDown.OnMinimumChanged((int)e.OldValue, (int)e.NewValue);
        }

        protected virtual void OnMinimumChanged(int oldValue, int newValue)
        {
            //SetValidSpinDirection();
        }

        #endregion //Minimum

        #region SelectAllOnGotFocus

        public static readonly DependencyProperty SelectAllOnGotFocusProperty = DependencyProperty.Register("SelectAllOnGotFocus", typeof(bool), typeof(IntegerUpDown), new PropertyMetadata(false));
        public bool SelectAllOnGotFocus
        {
            get { return (bool)GetValue(SelectAllOnGotFocusProperty); }
            set { SetValue(SelectAllOnGotFocusProperty, value); }
        }

        #endregion //SelectAllOnGotFocus

        #endregion //Properties

        #region Constructors

        static IntegerUpDown()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IntegerUpDown), new FrameworkPropertyMetadata(typeof(IntegerUpDown)));
        }

        #endregion //Constructors

        #region Base Class Overrides

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if (SelectAllOnGotFocus)
            {
                //in order to select all the text we must handle both the keybord (tabbing) and mouse (clicking) events
                TextBox.GotKeyboardFocus += OnTextBoxGotKeyBoardFocus;
                TextBox.PreviewMouseLeftButtonDown += OnTextBoxPreviewMouseLeftButtonDown;
            }

            //SetValidSpinDirection();
        }

        protected override int? OnCoerceValue(int? value)
        {
            if (value == null) return value;

            int val = value.Value;

            if (value < Minimum)
                return Minimum;
            else if (value > Maximum)
                return Maximum;
            else
                return value;
        }

        protected override void OnIncrement()
        {
            if (Value.HasValue)
                Value += Increment;
            else
                Value = DefaultValue;
        }

        protected override void OnDecrement()
        {
            if (Value.HasValue)
                Value -= Increment;
            else
                Value = DefaultValue;
        }

        protected override int? ConvertTextToValue(string text)
        {
            int? result = null;

            if (String.IsNullOrEmpty(text))
                return result;

            try
            {
                result = Int32.Parse(text, System.Globalization.NumberStyles.Any, CultureInfo);
            }
            catch
            {
                Text = ConvertValueToText();
                return Value;
            }

            return result;
        }

        protected override string ConvertValueToText()
        {
            if (Value == null)
                return string.Empty;

            return Value.Value.ToString(FormatString, CultureInfo);
        }

        protected override void OnValueChanged(int? oldValue, int? newValue)
        {
            //SetValidSpinDirection();
            base.OnValueChanged(oldValue, newValue);
        }

        #endregion //Base Class Overrides

        #region Event Handlers

        private void OnTextBoxGotKeyBoardFocus(object sender, RoutedEventArgs e)
        {
            TextBox.SelectAll();
        }

        void OnTextBoxPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!TextBox.IsKeyboardFocused)
            {
                e.Handled = true;
                TextBox.Focus();
            }
        }

        #endregion //Event Handlers

        #region Methods

        /// <summary>
        /// Sets the valid spin direction based on current value, minimum and maximum.
        /// </summary>
        //private void SetValidSpinDirection()
        //{
        //    ValidSpinDirections validDirections = ValidSpinDirections.None;

        //    if (Value < Maximum)
        //        validDirections = validDirections | ValidSpinDirections.Increase;

        //    if (Value > Minimum)
        //        validDirections = validDirections | ValidSpinDirections.Decrease;

        //    if (Spinner != null)
        //        Spinner.ValidSpinDirection = validDirections;
        //}

        #endregion //Methods
    }
}