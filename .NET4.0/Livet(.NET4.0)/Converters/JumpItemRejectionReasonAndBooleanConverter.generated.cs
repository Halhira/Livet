﻿//このコードはT4 Templateによって自動生成されています。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Controls.Primitives;
using System.ComponentModel;
using System.Windows.Interop;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Documents.Serialization;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using System.Windows.Annotations;
using System.Windows.Ink;
using System.Windows.Automation.Peers;
using System.Windows.Markup.Localizer;
using System.Windows.Media.Imaging;
using System.IO.Packaging;
using System.Security.RightsManagement;
using System.Windows.Threading;
using System.Windows.Media.Effects;
using System.Windows.Shell;
using System.Security.Permissions;
using System.Windows.Annotations.Storage;
using System.Diagnostics;

namespace Livet.Converters
{
	/// <summary>
    /// JumpItemRejectionReason列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class JumpItemRejectionReasonAndBooleanConverter : IValueConverter
    {
        //VM→View
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is bool)) throw new ArgumentException();

            if ((bool)value)
            {
                if (_isConvertWhenTrueSet)
                {
                    return ConvertWhenTrue;
                }
            }
            else
            {
                if (_isConvertWhenFalseSet)
                {
                    return ConvertWhenFalse;
                }
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertWhenTrueSet;
        private JumpItemRejectionReason _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのJumpItemRejectionReason列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public JumpItemRejectionReason ConvertWhenTrue
        {
            get
            {
                return _convertWhenTrue;
            }
            set
            {
                _convertWhenTrue = value;
                _isConvertWhenTrueSet = true;
            }
        }

        private bool _isConvertWhenFalseSet;
        private JumpItemRejectionReason _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのJumpItemRejectionReason列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public JumpItemRejectionReason ConvertWhenFalse
        {
            get
            {
                return _convertWhenFalse;
            }
            set
            {
                _convertWhenFalse = value;
                _isConvertWhenFalseSet = true;
            }
        }

        //View→VM
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is JumpItemRejectionReason)) throw new ArgumentException();

            var enumValue = (JumpItemRejectionReason)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "InvalidItem":
					if (_isConvertBackWhenInvalidItemSet)
					{
						return ConvertBackWhenInvalidItem;
					}
					break;
				case "NoRegisteredHandler":
					if (_isConvertBackWhenNoRegisteredHandlerSet)
					{
						return ConvertBackWhenNoRegisteredHandler;
					}
					break;
				case "RemovedByUser":
					if (_isConvertBackWhenRemovedByUserSet)
					{
						return ConvertBackWhenRemovedByUser;
					}
					break;
				default:
					throw new ArgumentException();
			}

            if (_isConvertBackDefaultBooleanValueSet)
            {
                return ConvertBackDefaultBooleanValue;
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertBackDefaultBooleanValueSet;
        private bool _convertBackDefaultBooleanValue;
		/// <summary>
        /// JumpItemRejectionReasonの値をbool値に変換する際のデフォルト値を指定、または取得します。
        /// </summary>
        public bool ConvertBackDefaultBooleanValue
        {
            get
            {
                return _convertBackDefaultBooleanValue;
            }
            set
            {
                _convertBackDefaultBooleanValue = value;
				_isConvertBackDefaultBooleanValueSet = true;
            }
        }

        private bool _isConvertBackWhenNoneSet;
        private bool _convertBackWhenNone;
		/// <summary>
        /// JumpItemRejectionReasonの値がNoneの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNone
        {
            get
            {
                return _convertBackWhenNone;
            }
            set
            {
                _convertBackWhenNone = value;
                _isConvertBackWhenNoneSet = true;
            }
        }
        private bool _isConvertBackWhenInvalidItemSet;
        private bool _convertBackWhenInvalidItem;
		/// <summary>
        /// JumpItemRejectionReasonの値がInvalidItemの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenInvalidItem
        {
            get
            {
                return _convertBackWhenInvalidItem;
            }
            set
            {
                _convertBackWhenInvalidItem = value;
                _isConvertBackWhenInvalidItemSet = true;
            }
        }
        private bool _isConvertBackWhenNoRegisteredHandlerSet;
        private bool _convertBackWhenNoRegisteredHandler;
		/// <summary>
        /// JumpItemRejectionReasonの値がNoRegisteredHandlerの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenNoRegisteredHandler
        {
            get
            {
                return _convertBackWhenNoRegisteredHandler;
            }
            set
            {
                _convertBackWhenNoRegisteredHandler = value;
                _isConvertBackWhenNoRegisteredHandlerSet = true;
            }
        }
        private bool _isConvertBackWhenRemovedByUserSet;
        private bool _convertBackWhenRemovedByUser;
		/// <summary>
        /// JumpItemRejectionReasonの値がRemovedByUserの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRemovedByUser
        {
            get
            {
                return _convertBackWhenRemovedByUser;
            }
            set
            {
                _convertBackWhenRemovedByUser = value;
                _isConvertBackWhenRemovedByUserSet = true;
            }
        }
    }
}