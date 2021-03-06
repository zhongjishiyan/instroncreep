using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using Cells = SourceGrid2.Cells.Real;

namespace SampleProject.Extensions
{
	/// <summary>
	/// Summary description for GridBarChart.
	/// </summary>
	public class GridBarChart : System.Windows.Forms.UserControl
	{
		private SourceGrid2.Grid grid;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GridBarChart()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grid = new SourceGrid2.Grid();
			this.SuspendLayout();
			// 
			// grid
			// 
			this.grid.AutoSizeMinHeight = 10;
			this.grid.AutoSizeMinWidth = 10;
			this.grid.AutoStretchColumnsToFitWidth = false;
			this.grid.AutoStretchRowsToFitHeight = false;
			this.grid.ContextMenuStyle = SourceGrid2.ContextMenuStyle.None;
			this.grid.CustomSort = false;
			this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid.GridToolTipActive = true;
			this.grid.Location = new System.Drawing.Point(0, 0);
			this.grid.Name = "grid";
			this.grid.Size = new System.Drawing.Size(556, 444);
			this.grid.SpecialKeys = SourceGrid2.GridSpecialKeys.Default;
			this.grid.TabIndex = 0;
			// 
			// GridBarChart
			// 
			this.Controls.Add(this.grid);
			this.Name = "GridBarChart";
			this.Size = new System.Drawing.Size(556, 444);
			this.ResumeLayout(false);

		}
		#endregion

		private ChartBarCollection m_Bars = new ChartBarCollection();

		public ChartBarCollection Bars
		{
			get{return m_Bars;}
		}

		private int m_StepNumber = 20;

		public int StepNumber
		{
			get{return m_StepNumber;}
			set{m_StepNumber = value;}
		}

		public void LoadChart()
		{
			grid.Redim(0,0);
			if (Bars.Count > 0)
			{
				double l_Max = double.MinValue;
				double l_Min = double.MaxValue;
				for (int i = 0; i < m_Bars.Count; i++)
				{
					if (m_Bars[i].值 > l_Max)
						l_Max = m_Bars[i].值;

					if (m_Bars[i].值 < l_Min)
						l_Min = m_Bars[i].值;
				}

				//l_Min -= ((l_Max-l_Min)/((double)m_StepNumber))*2;//per fare in modo che ance il pi?piccolo sia visibile
				double l_ScalingFactor = ((double)m_StepNumber)/(l_Max-l_Min);

				//Draw Background
				SourceGrid2.VisualModels.Common l_TopBorderModel = new SourceGrid2.VisualModels.Common(false);
				l_TopBorderModel.Border = new SourceGrid2.RectangleBorder(new SourceGrid2.Border(Color.Black, 1), new SourceGrid2.Border(Color.Black, 0), new SourceGrid2.Border(Color.Black, 0), new SourceGrid2.Border(Color.Black, 0) );
				l_TopBorderModel.BackColor = grid.BackColor;
				l_TopBorderModel.TextAlignment = ContentAlignment.MiddleCenter;
				SourceGrid2.VisualModels.Common l_RightBorderModel = new SourceGrid2.VisualModels.Common(false);
				l_RightBorderModel.Border = new SourceGrid2.RectangleBorder(new SourceGrid2.Border(Color.Black, 0), new SourceGrid2.Border(Color.Black, 0), new SourceGrid2.Border(Color.Black, 0), new SourceGrid2.Border(Color.Black, 1) );
				l_RightBorderModel.BackColor = grid.BackColor;
				l_RightBorderModel.TextAlignment = ContentAlignment.BottomRight;
				SourceGrid2.VisualModels.Common l_RightTopBorderModel = new SourceGrid2.VisualModels.Common(false);
				l_RightTopBorderModel.Border = new SourceGrid2.RectangleBorder(new SourceGrid2.Border(Color.Black, 1), new SourceGrid2.Border(Color.Black, 0), new SourceGrid2.Border(Color.Black, 0), new SourceGrid2.Border(Color.Black, 1) );
				l_RightTopBorderModel.BackColor = grid.BackColor;

				grid.Redim(m_StepNumber+2,m_Bars.Count*2 + 2); //+ 1 per gli header e per uno spazio in alto e in basso

				//barra X
				for (int c = 1; c < grid.ColumnsCount; c++)
					grid[grid.RowsCount-1, c] = new Cells.Cell((object)null, null, l_TopBorderModel);

				//barra Y
				double l_YValue = l_Max;
				for (int r = 0; r < grid.RowsCount-1; r++)
				{
					grid[r, 0] = new Cells.Cell(l_YValue.ToString() + " _", null, l_RightBorderModel);
					l_YValue -= 1/l_ScalingFactor;
				}

				//left bottom cell
				grid[grid.RowsCount-1, 0] = new Cells.Cell((object)null, null, l_RightTopBorderModel);

				//bars header
				int l_Col = 2;
				foreach (ChartBar bar in Bars)
				{
					grid[grid.RowsCount-1, l_Col] = new Cells.Cell(bar.名称 + "\n" + bar.值.ToString(), null, l_TopBorderModel);

					l_Col += 2;
				}

				grid.AutoStretchColumnsToFitWidth = true;
				grid.AutoStretchRowsToFitHeight = true;
				grid.AutoSizeAll(5,5);

				//bars
				l_Col = 2;
				foreach (ChartBar bar in Bars)
				{
					int l_ScaledValue = (int)((bar.值-l_Min) * l_ScalingFactor);

					if (l_ScaledValue>0)
					{
						grid[(StepNumber - l_ScaledValue) + 1, l_Col] = bar.CreateCell();
						grid[(StepNumber - l_ScaledValue) + 1, l_Col].RowSpan = l_ScaledValue;
					}

					grid[grid.RowsCount-1, l_Col] = new Cells.Cell(bar.名称 + "\n" + bar.值.ToString(), null, l_TopBorderModel);

					l_Col += 2;
				}
			}
		}
	}

    public class ChartBarTextDefine : ChartBar
    {
        private string m_docname = "";
        private string m_docvalue = "";
        private int m_dimsel = 0;
        public ChartBarTextDefine()
        {
          
             
        }

        public string 文档名称
        {
            get { return m_docname; }
            set { m_docname = value; }
        }

        public string 文档内容
        {
            get { return m_docvalue; }
            set { m_docvalue = value; }
        }

        private int 量纲
        {
            get { return m_dimsel; }
            set { m_dimsel = value; }
        }


        private string 名称
        {
            get { return ""; }
        }

        private double 值
        {
            get { return 0; }
        }

        private string 单位
        {
            get { return ""; }
        }

        public ChartBarTextDefine(string p_docname, string p_docvalue)
        {
            文档名称 = p_docname;
            文档内容 = p_docvalue; 
        }

    }
    public class ChartBarComboDefine : ChartBar
    {
        private string m_docname = "";
        private string m_docvalue;
        private int m_dimsel = 0;
        private int m_sel = 0;

        public ChartBarComboDefine()
        {


        }

        public string 组合框名称
        {
            get { return m_docname; }
            set { m_docname = value; }
        }

        public string 组合框内容
        {
            get { return m_docvalue; }
            set { m_docvalue = value; }
        }

        public int 选择
        {
            get { return m_sel; }
            set { m_sel = value; }

        }

        private int 量纲
        {
            get { return m_dimsel; }
            set { m_dimsel = value; }
        }


        private string 名称
        {
            get { return ""; }
        }

        private double 值
        {
            get { return 0; }
        }

        private string 单位
        {
            get { return ""; }
        }

        public ChartBarComboDefine(string p_docname, string p_docvalue,int p_sel)
        {
            组合框名称 = p_docname;
           
            组合框内容 = p_docvalue;
            选择 = p_sel; 
        }

    }
    public class ChartBarChannelDefine : ChartBar
    {

        private string m_Caption = "计算项目";
        private string m_Value = "";
        private string m_unit = "";//基本量纲
        private bool m_check = false;

        private string  m_dimensionkind;//量纲选择

        public ChartBarChannelDefine()
        {
          
             
        }

        public string value;

        public string 通道名称
        {
            get { return m_Caption; }
            set { m_Caption = value; }
        }

        public string 通道内容
        {
            get { return m_Value; }
            set { m_Value = value; }
        }

        public string 通道基本单位
        {
            get { return m_unit; }
            set { m_unit = value; }
        }


        public string 通道量纲
        {
            get { return m_dimensionkind; }
            set {
                m_dimensionkind = value;
                    
                 }
        }

        private string 名称
        {
            get { return ""; }
        }

        private double 值
        {
            get { return 0; }
        }

        private string 单位
        {
            get { return ""; }
        }

        public ChartBarChannelDefine(string p_Caption, string p_Value, string p_Unit, string p_d,  Color p_Color, Color p_ForeColor)
        {
            通道名称 = p_Caption;
            通道内容 = p_Value;
            通道基本单位 = p_Unit;
            通道量纲 = p_d;

        }


    }


    public class ChartBarDefine : ChartBar
    {
        
        private string m_Caption = "计算项目";
        private string  m_Value = "";
        private string m_unit = "mm";
        private string m_explain = "";
        private bool  m_check=false ;
        private bool m_show = false;
        private int m_dimsel = 0;
        public ChartBarDefine()
        {

        }

        public string value;

        public string 公式名称
        {
            get { return m_Caption; }
            set { m_Caption = value; }
        }

        public string  公式内容
        {
            get { return m_Value; }
            set { m_Value = value; }
        }

        public string 公式单位
        {
            get { return m_unit; }
            set { m_unit = value; }
        }


        public bool 是否计算
        {
            get { return m_check; }
            set { m_check = value; }


        }

        public string 公式说明
        {
            get { return m_explain; }
            set { m_explain = value; }
        }

        public bool 曲线显示
        {
            get { return m_show; }
            set { m_show = value; }
        }
        public int 量纲
        {
            get { return m_dimsel; }
            set { m_dimsel = value; }
        }


        private string 名称
        {
            get { return ""; }
        }

        private double 值
        {
            get { return 0; }
        }

        private string 单位
        {
            get { return ""; }
        }

        public ChartBarDefine(string p_Caption, string p_Value, string p_Unit, bool p_check, int p_dimsel, string p_explain,bool p_show,  Color p_Color, Color p_ForeColor)
		{
			公式名称 = p_Caption;
			公式内容 = p_Value;
            公式单位 = p_Unit;
            是否计算 = p_check;
            量纲 = p_dimsel;
            公式说明 =p_explain;
            曲线显示 = p_show;
		}


    }

	public class ChartBar
	{
		private string m_Caption = "变量名";
		private double m_Value = 0;
        private string m_unit = "mm";
        private int m_dimsel ;
		private Color m_Color = Color.SteelBlue;
		private Color m_ForeColor = Color.White;

		public ChartBar()
		{
		}

		public string 名称
		{
			get{return m_Caption;}
			set{m_Caption = value;}
		}

		public double 值
		{
			get{return m_Value;}
			set{m_Value = value;}
		}

        

        public string  单位
        {
            
            get { return m_unit; }
            set { m_unit = value; }
        }

        public int 量纲
        {
            get { return m_dimsel; }
            set { m_dimsel = value; }
        }



		private Color Color
		{
			get{return m_Color;}
			set{m_Color = value;}
		}

		private Color ForeColor
		{
			get{return m_ForeColor;}
			set{m_ForeColor = value;}
		}

		public ChartBar(string p_Caption, double p_Value,  string  p_Unit, int p_dimsel, Color p_Color, Color p_ForeColor)
		{
			名称 = p_Caption;
			值 = p_Value;
            单位 = p_Unit;
            量纲 = p_dimsel;
			Color = p_Color;
			ForeColor = p_ForeColor;
		}

		public Cells.Cell CreateCell()
		{
			SourceGrid2.VisualModels.Header l_VisualModel = new SourceGrid2.VisualModels.Header(false);
			l_VisualModel.StringFormat.FormatFlags |= StringFormatFlags.DirectionVertical;
			//l_VisualModel.Border = new SourceGrid2.RectangleBorder(new SourceGrid2.Border(Color.Black, 1));
			l_VisualModel.HeaderLightColor = Color.White;
			l_VisualModel.HeaderLightBorderWidth = 6;
			l_VisualModel.HeaderShadowBorderWidth = 4;
			l_VisualModel.HeaderShadowColor = Color.Gray;
			l_VisualModel.BackColor = Color;
			l_VisualModel.TextAlignment = ContentAlignment.MiddleCenter;
			l_VisualModel.ForeColor = ForeColor;

			Cells.Cell l_Cell = new SourceGrid2.Cells.Real.Cell(名称, null, l_VisualModel);
			l_Cell.ToolTipText = 名称 + " - " + 值.ToString();
			return l_Cell;
		}
	}

	/// <summary>
	/// A collection of elements of type ChartBar
	/// </summary>
	public class ChartBarCollection: System.Collections.CollectionBase
	{
		/// <summary>
		/// Initializes a new empty instance of the ChartBarCollection class.
		/// </summary>
		public ChartBarCollection()
		{
			// empty
		}

		/// <summary>
		/// Initializes a new instance of the ChartBarCollection class, containing elements
		/// copied from an array.
		/// </summary>
		/// <param name="items">
		/// The array whose elements are to be added to the new ChartBarCollection.
		/// </param>
		public ChartBarCollection(ChartBar[] items)
		{
			this.AddRange(items);
		}

		/// <summary>
		/// Initializes a new instance of the ChartBarCollection class, containing elements
		/// copied from another instance of ChartBarCollection
		/// </summary>
		/// <param name="items">
		/// The ChartBarCollection whose elements are to be added to the new ChartBarCollection.
		/// </param>
		public ChartBarCollection(ChartBarCollection items)
		{
			this.AddRange(items);
		}

		/// <summary>
		/// Adds the elements of an array to the end of this ChartBarCollection.
		/// </summary>
		/// <param name="items">
		/// The array whose elements are to be added to the end of this ChartBarCollection.
		/// </param>
		public virtual void AddRange(ChartBar[] items)
		{
			foreach (ChartBar item in items)
			{
				this.List.Add(item);
			}
		}

		/// <summary>
		/// Adds the elements of another ChartBarCollection to the end of this ChartBarCollection.
		/// </summary>
		/// <param name="items">
		/// The ChartBarCollection whose elements are to be added to the end of this ChartBarCollection.
		/// </param>
		public virtual void AddRange(ChartBarCollection items)
		{
			foreach (ChartBar item in items)
			{
				this.List.Add(item);
			}
		}

		/// <summary>
		/// Adds an instance of type ChartBar to the end of this ChartBarCollection.
		/// </summary>
		/// <param name="value">
		/// The ChartBar to be added to the end of this ChartBarCollection.
		/// </param>
		public virtual void Add(ChartBar value)
		{
			this.List.Add(value);
		}

		/// <summary>
		/// Determines whether a specfic ChartBar value is in this ChartBarCollection.
		/// </summary>
		/// <param name="value">
		/// The ChartBar value to locate in this ChartBarCollection.
		/// </param>
		/// <returns>
		/// true if value is found in this ChartBarCollection;
		/// false otherwise.
		/// </returns>
		public virtual bool Contains(ChartBar value)
		{
			return this.List.Contains(value);
		}

		/// <summary>
		/// Return the zero-based index of the first occurrence of a specific value
		/// in this ChartBarCollection
		/// </summary>
		/// <param name="value">
		/// The ChartBar value to locate in the ChartBarCollection.
		/// </param>
		/// <returns>
		/// The zero-based index of the first occurrence of the _ELEMENT value if found;
		/// -1 otherwise.
		/// </returns>
		public virtual int IndexOf(ChartBar value)
		{
			return this.List.IndexOf(value);
		}

		/// <summary>
		/// Inserts an element into the ChartBarCollection at the specified index
		/// </summary>
		/// <param name="index">
		/// The index at which the ChartBar is to be inserted.
		/// </param>
		/// <param name="value">
		/// The ChartBar to insert.
		/// </param>
		public virtual void Insert(int index, ChartBar value)
		{
			this.List.Insert(index, value);
		}

		/// <summary>
		/// Gets or sets the ChartBar at the given index in this ChartBarCollection.
		/// </summary>
		public virtual ChartBar this[int index]
		{
			get
			{
				return (ChartBar) this.List[index];
			}
			set
			{
				this.List[index] = value;
			}
		}

		/// <summary>
		/// Removes the first occurrence of a specific ChartBar from this ChartBarCollection.
		/// </summary>
		/// <param name="value">
		/// The ChartBar value to remove from this ChartBarCollection.
		/// </param>
		public virtual void Remove(ChartBar value)
		{
			this.List.Remove(value);
		}

		/// <summary>
		/// Type-specific enumeration class, used by ChartBarCollection.GetEnumerator.
		/// </summary>
		public class Enumerator: System.Collections.IEnumerator
		{
			private System.Collections.IEnumerator wrapped;

			public Enumerator(ChartBarCollection collection)
			{
				this.wrapped = ((System.Collections.CollectionBase)collection).GetEnumerator();
			}

			public ChartBar Current
			{
				get
				{
					return (ChartBar) (this.wrapped.Current);
				}
			}

			object System.Collections.IEnumerator.Current
			{
				get
				{
					return (ChartBar) (this.wrapped.Current);
				}
			}

			public bool MoveNext()
			{
				return this.wrapped.MoveNext();
			}

			public void Reset()
			{
				this.wrapped.Reset();
			}
		}

		/// <summary>
		/// Returns an enumerator that can iterate through the elements of this ChartBarCollection.
		/// </summary>
		/// <returns>
		/// An object that implements System.Collections.IEnumerator.
		/// </returns>        
		public new virtual ChartBarCollection.Enumerator GetEnumerator()
		{
			return new ChartBarCollection.Enumerator(this);
		}
	}
}
