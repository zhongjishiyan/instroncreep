using System;
using System.Drawing;

namespace SourceGrid2.Cells.Virtual
{
	/// <summary>
	/// Class that rapresent a col header with sort and resize feature.
	/// </summary>
	public abstract class ColumnHeader : Header, ICellSortableHeader
	{
		public ColumnHeader():base(VisualModels.Header.ColumnHeader, BehaviorModels.ColumnHeader.SortableHeader)
		{
		}

		#region ICellSortableHeader Members

		public abstract SortStatus GetSortStatus(Position p_Position);

		public abstract void SetSortMode(Position p_Position, GridSortMode p_Mode);

		#endregion
	}

}

namespace SourceGrid2.Cells.Real
{
	/// <summary>
	/// Class that rapresent a col header with sort and resize feature.
	/// </summary>
	public class ColumnHeader : Header, ICellSortableHeader
	{
		public ColumnHeader():base(null, VisualModels.Header.ColumnHeader, BehaviorModels.ColumnHeader.SortableHeader)
		{
		}

		public ColumnHeader(object p_Value):base(p_Value, VisualModels.Header.ColumnHeader, BehaviorModels.ColumnHeader.SortableHeader)
		{
		}

		#region ICellSortableHeader Members

		private SourceGrid2.GridSortMode m_SortStatus = GridSortMode.None;
		public SourceGrid2.GridSortMode SortMode
		{
			get{return m_SortStatus;}
			set{m_SortStatus = value;}
		}

		private bool m_EnableSort = true;
		public bool EnableSort
		{
			get{return m_EnableSort;}
			set{m_EnableSort = value;}
		}

		private System.Collections.IComparer m_Comparer;
		/// <summary>
		/// Comparer used to sort the cells. If null the default comparer is used.
		/// </summary>
		public System.Collections.IComparer Comparer
		{
			get{return m_Comparer;}
			set{m_Comparer = value;}
		}

		public virtual SortStatus GetSortStatus(Position p_Position)
		{
			return new SortStatus(m_SortStatus, m_EnableSort, m_Comparer);
		}

		public virtual void SetSortMode(Position p_Position, GridSortMode p_Mode)
		{
			SortMode = p_Mode;
		}

		#endregion
	}

}
