using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;


namespace SourceGrid2.DataModels
{
	/// <summary>
	/// A DataModel that use a TextBoxTypedNumeric for editing support. You can customize the NumericCharStyle property to enable char validation.
	/// This class automatically set the ValidCharacters and InvalidCharacters using SourceLibrary.Windows.Forms.TextBoxTypedNumeric.CreateNumericValidChars method.
	/// </summary>
	public class EditorTextBoxNumeric : EditorTextBox
	{
		#region Constructor
		/// <summary>
		/// Construct a Model. Based on the Type specified the constructor populate AllowNull, DefaultValue, TypeConverter, StandardValues, StandardValueExclusive
		/// </summary>
		/// <param name="p_Type">The type of this model</param>
		public EditorTextBoxNumeric(Type p_Type):base(p_Type)
		{
		}
		#endregion

		#region Edit Control
		public override Control CreateEditorControl()
		{
			SourceLibrary.Windows.Forms.TextBoxTypedNumeric l_Control = new SourceLibrary.Windows.Forms.TextBoxTypedNumeric();
			l_Control.BorderStyle = BorderStyle.None;
			l_Control.AutoSize = false;
			return l_Control;
		}
		public virtual SourceLibrary.Windows.Forms.TextBoxTypedNumeric GetEditorTextBoxNumeric(GridVirtual p_Grid)
		{
			return (SourceLibrary.Windows.Forms.TextBoxTypedNumeric)GetEditorControl(p_Grid);
		}
		#endregion

		public override void InternalStartEdit(SourceGrid2.Cells.ICellVirtual p_Cell, Position p_Position, object p_StartEditValue)
		{
			ValidCharacters = SourceLibrary.Windows.Forms.TextBoxTypedNumeric.CreateNumericValidChars(CultureInfo, m_NumericCharStyle);
			InvalidCharacters = null;
			base.InternalStartEdit (p_Cell, p_Position, p_StartEditValue);
		}

		private SourceLibrary.Windows.Forms.NumericCharStyle m_NumericCharStyle = SourceLibrary.Windows.Forms.NumericCharStyle.DecimalSeparator | SourceLibrary.Windows.Forms.NumericCharStyle.NegativeSymbol;

		/// <summary>
		/// This property automatically set the ValidCharacters and InvalidCharacters using SourceLibrary.Windows.Forms.TextBoxTypedNumeric.CreateNumericValidChars method.
		/// </summary>
		public SourceLibrary.Windows.Forms.NumericCharStyle NumericCharStyle
		{
			get{return m_NumericCharStyle;}
			set{m_NumericCharStyle = value;}
		}
	}
}