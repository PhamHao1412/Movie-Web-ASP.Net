﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PHAMANHAO_TEST2.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Test22")]
	public partial class dbTest2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPhim(Phim instance);
    partial void UpdatePhim(Phim instance);
    partial void DeletePhim(Phim instance);
    partial void InsertChiTiet(ChiTiet instance);
    partial void UpdateChiTiet(ChiTiet instance);
    partial void DeleteChiTiet(ChiTiet instance);
    partial void InsertHoaDon(HoaDon instance);
    partial void UpdateHoaDon(HoaDon instance);
    partial void DeleteHoaDon(HoaDon instance);
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertLichChieu(LichChieu instance);
    partial void UpdateLichChieu(LichChieu instance);
    partial void DeleteLichChieu(LichChieu instance);
    #endregion
		
		public dbTest2DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Test22ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbTest2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbTest2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbTest2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbTest2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Phim> Phims
		{
			get
			{
				return this.GetTable<Phim>();
			}
		}
		
		public System.Data.Linq.Table<ChiTiet> ChiTiets
		{
			get
			{
				return this.GetTable<ChiTiet>();
			}
		}
		
		public System.Data.Linq.Table<HoaDon> HoaDons
		{
			get
			{
				return this.GetTable<HoaDon>();
			}
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<LichChieu> LichChieus
		{
			get
			{
				return this.GetTable<LichChieu>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Phim")]
	public partial class Phim : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _maphim;
		
		private string _tenphim;
		
		private string _daodien;
		
		private string _hinh;
		
		private System.Nullable<System.DateTime> _ngaychieu;
		
		private EntitySet<LichChieu> _LichChieus;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmaphimChanging(int value);
    partial void OnmaphimChanged();
    partial void OntenphimChanging(string value);
    partial void OntenphimChanged();
    partial void OndaodienChanging(string value);
    partial void OndaodienChanged();
    partial void OnhinhChanging(string value);
    partial void OnhinhChanged();
    partial void OnngaychieuChanging(System.Nullable<System.DateTime> value);
    partial void OnngaychieuChanged();
    #endregion
		
		public Phim()
		{
			this._LichChieus = new EntitySet<LichChieu>(new Action<LichChieu>(this.attach_LichChieus), new Action<LichChieu>(this.detach_LichChieus));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maphim", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int maphim
		{
			get
			{
				return this._maphim;
			}
			set
			{
				if ((this._maphim != value))
				{
					this.OnmaphimChanging(value);
					this.SendPropertyChanging();
					this._maphim = value;
					this.SendPropertyChanged("maphim");
					this.OnmaphimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tenphim", DbType="NVarChar(30)")]
		public string tenphim
		{
			get
			{
				return this._tenphim;
			}
			set
			{
				if ((this._tenphim != value))
				{
					this.OntenphimChanging(value);
					this.SendPropertyChanging();
					this._tenphim = value;
					this.SendPropertyChanged("tenphim");
					this.OntenphimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_daodien", DbType="NVarChar(30)")]
		public string daodien
		{
			get
			{
				return this._daodien;
			}
			set
			{
				if ((this._daodien != value))
				{
					this.OndaodienChanging(value);
					this.SendPropertyChanging();
					this._daodien = value;
					this.SendPropertyChanged("daodien");
					this.OndaodienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hinh", DbType="VarChar(50)")]
		public string hinh
		{
			get
			{
				return this._hinh;
			}
			set
			{
				if ((this._hinh != value))
				{
					this.OnhinhChanging(value);
					this.SendPropertyChanging();
					this._hinh = value;
					this.SendPropertyChanged("hinh");
					this.OnhinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaychieu", DbType="Date")]
		public System.Nullable<System.DateTime> ngaychieu
		{
			get
			{
				return this._ngaychieu;
			}
			set
			{
				if ((this._ngaychieu != value))
				{
					this.OnngaychieuChanging(value);
					this.SendPropertyChanging();
					this._ngaychieu = value;
					this.SendPropertyChanged("ngaychieu");
					this.OnngaychieuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phim_LichChieu", Storage="_LichChieus", ThisKey="maphim", OtherKey="maphim")]
		public EntitySet<LichChieu> LichChieus
		{
			get
			{
				return this._LichChieus;
			}
			set
			{
				this._LichChieus.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_LichChieus(LichChieu entity)
		{
			this.SendPropertyChanging();
			entity.Phim = this;
		}
		
		private void detach_LichChieus(LichChieu entity)
		{
			this.SendPropertyChanging();
			entity.Phim = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTiet")]
	public partial class ChiTiet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _mahd;
		
		private string _malich;
		
		private System.Nullable<int> _soluong;
		
		private EntityRef<HoaDon> _HoaDon;
		
		private EntityRef<LichChieu> _LichChieu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmahdChanging(int value);
    partial void OnmahdChanged();
    partial void OnmalichChanging(string value);
    partial void OnmalichChanged();
    partial void OnsoluongChanging(System.Nullable<int> value);
    partial void OnsoluongChanged();
    #endregion
		
		public ChiTiet()
		{
			this._HoaDon = default(EntityRef<HoaDon>);
			this._LichChieu = default(EntityRef<LichChieu>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mahd", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int mahd
		{
			get
			{
				return this._mahd;
			}
			set
			{
				if ((this._mahd != value))
				{
					if (this._HoaDon.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmahdChanging(value);
					this.SendPropertyChanging();
					this._mahd = value;
					this.SendPropertyChanged("mahd");
					this.OnmahdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_malich", DbType="Char(7) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string malich
		{
			get
			{
				return this._malich;
			}
			set
			{
				if ((this._malich != value))
				{
					if (this._LichChieu.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmalichChanging(value);
					this.SendPropertyChanging();
					this._malich = value;
					this.SendPropertyChanged("malich");
					this.OnmalichChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soluong", DbType="Int")]
		public System.Nullable<int> soluong
		{
			get
			{
				return this._soluong;
			}
			set
			{
				if ((this._soluong != value))
				{
					this.OnsoluongChanging(value);
					this.SendPropertyChanging();
					this._soluong = value;
					this.SendPropertyChanged("soluong");
					this.OnsoluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HoaDon_ChiTiet", Storage="_HoaDon", ThisKey="mahd", OtherKey="MaHD", IsForeignKey=true)]
		public HoaDon HoaDon
		{
			get
			{
				return this._HoaDon.Entity;
			}
			set
			{
				HoaDon previousValue = this._HoaDon.Entity;
				if (((previousValue != value) 
							|| (this._HoaDon.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HoaDon.Entity = null;
						previousValue.ChiTiets.Remove(this);
					}
					this._HoaDon.Entity = value;
					if ((value != null))
					{
						value.ChiTiets.Add(this);
						this._mahd = value.MaHD;
					}
					else
					{
						this._mahd = default(int);
					}
					this.SendPropertyChanged("HoaDon");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LichChieu_ChiTiet", Storage="_LichChieu", ThisKey="malich", OtherKey="malich", IsForeignKey=true)]
		public LichChieu LichChieu
		{
			get
			{
				return this._LichChieu.Entity;
			}
			set
			{
				LichChieu previousValue = this._LichChieu.Entity;
				if (((previousValue != value) 
							|| (this._LichChieu.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LichChieu.Entity = null;
						previousValue.ChiTiets.Remove(this);
					}
					this._LichChieu.Entity = value;
					if ((value != null))
					{
						value.ChiTiets.Add(this);
						this._malich = value.malich;
					}
					else
					{
						this._malich = default(string);
					}
					this.SendPropertyChanged("LichChieu");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HoaDon")]
	public partial class HoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHD;
		
		private System.Nullable<System.DateTime> _NgayMua;
		
		private System.Nullable<int> _MaKH;
		
		private EntitySet<ChiTiet> _ChiTiets;
		
		private EntityRef<KhachHang> _KhachHang;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(int value);
    partial void OnMaHDChanged();
    partial void OnNgayMuaChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayMuaChanged();
    partial void OnMaKHChanging(System.Nullable<int> value);
    partial void OnMaKHChanged();
    #endregion
		
		public HoaDon()
		{
			this._ChiTiets = new EntitySet<ChiTiet>(new Action<ChiTiet>(this.attach_ChiTiets), new Action<ChiTiet>(this.detach_ChiTiets));
			this._KhachHang = default(EntityRef<KhachHang>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayMua", DbType="Date")]
		public System.Nullable<System.DateTime> NgayMua
		{
			get
			{
				return this._NgayMua;
			}
			set
			{
				if ((this._NgayMua != value))
				{
					this.OnNgayMuaChanging(value);
					this.SendPropertyChanging();
					this._NgayMua = value;
					this.SendPropertyChanged("NgayMua");
					this.OnNgayMuaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Int")]
		public System.Nullable<int> MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					if (this._KhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HoaDon_ChiTiet", Storage="_ChiTiets", ThisKey="MaHD", OtherKey="mahd")]
		public EntitySet<ChiTiet> ChiTiets
		{
			get
			{
				return this._ChiTiets;
			}
			set
			{
				this._ChiTiets.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_HoaDon", Storage="_KhachHang", ThisKey="MaKH", OtherKey="makh", IsForeignKey=true)]
		public KhachHang KhachHang
		{
			get
			{
				return this._KhachHang.Entity;
			}
			set
			{
				KhachHang previousValue = this._KhachHang.Entity;
				if (((previousValue != value) 
							|| (this._KhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhachHang.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._KhachHang.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._MaKH = value.makh;
					}
					else
					{
						this._MaKH = default(Nullable<int>);
					}
					this.SendPropertyChanged("KhachHang");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ChiTiets(ChiTiet entity)
		{
			this.SendPropertyChanging();
			entity.HoaDon = this;
		}
		
		private void detach_ChiTiets(ChiTiet entity)
		{
			this.SendPropertyChanging();
			entity.HoaDon = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _makh;
		
		private string _hoten;
		
		private string _matkhau;
		
		private string _diachi;
		
		private string _dienthoai;
		
		private EntitySet<HoaDon> _HoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmakhChanging(int value);
    partial void OnmakhChanged();
    partial void OnhotenChanging(string value);
    partial void OnhotenChanged();
    partial void OnmatkhauChanging(string value);
    partial void OnmatkhauChanged();
    partial void OndiachiChanging(string value);
    partial void OndiachiChanged();
    partial void OndienthoaiChanging(string value);
    partial void OndienthoaiChanged();
    #endregion
		
		public KhachHang()
		{
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_makh", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int makh
		{
			get
			{
				return this._makh;
			}
			set
			{
				if ((this._makh != value))
				{
					this.OnmakhChanging(value);
					this.SendPropertyChanging();
					this._makh = value;
					this.SendPropertyChanged("makh");
					this.OnmakhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hoten", DbType="NVarChar(50)")]
		public string hoten
		{
			get
			{
				return this._hoten;
			}
			set
			{
				if ((this._hoten != value))
				{
					this.OnhotenChanging(value);
					this.SendPropertyChanging();
					this._hoten = value;
					this.SendPropertyChanged("hoten");
					this.OnhotenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matkhau", DbType="VarChar(10)")]
		public string matkhau
		{
			get
			{
				return this._matkhau;
			}
			set
			{
				if ((this._matkhau != value))
				{
					this.OnmatkhauChanging(value);
					this.SendPropertyChanging();
					this._matkhau = value;
					this.SendPropertyChanged("matkhau");
					this.OnmatkhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diachi", DbType="NVarChar(100)")]
		public string diachi
		{
			get
			{
				return this._diachi;
			}
			set
			{
				if ((this._diachi != value))
				{
					this.OndiachiChanging(value);
					this.SendPropertyChanging();
					this._diachi = value;
					this.SendPropertyChanged("diachi");
					this.OndiachiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dienthoai", DbType="VarChar(15)")]
		public string dienthoai
		{
			get
			{
				return this._dienthoai;
			}
			set
			{
				if ((this._dienthoai != value))
				{
					this.OndienthoaiChanging(value);
					this.SendPropertyChanging();
					this._dienthoai = value;
					this.SendPropertyChanged("dienthoai");
					this.OndienthoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_HoaDon", Storage="_HoaDons", ThisKey="makh", OtherKey="MaKH")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LichChieu")]
	public partial class LichChieu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _malich;
		
		private System.Nullable<int> _maphim;
		
		private System.Nullable<System.DateTime> _ngay;
		
		private string _gio;
		
		private System.Nullable<decimal> _gia;
		
		private System.Nullable<int> _soluong;
		
		private EntitySet<ChiTiet> _ChiTiets;
		
		private EntityRef<Phim> _Phim;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmalichChanging(string value);
    partial void OnmalichChanged();
    partial void OnmaphimChanging(System.Nullable<int> value);
    partial void OnmaphimChanged();
    partial void OnngayChanging(System.Nullable<System.DateTime> value);
    partial void OnngayChanged();
    partial void OngioChanging(string value);
    partial void OngioChanged();
    partial void OngiaChanging(System.Nullable<decimal> value);
    partial void OngiaChanged();
    partial void OnsoluongChanging(System.Nullable<int> value);
    partial void OnsoluongChanged();
    #endregion
		
		public LichChieu()
		{
			this._ChiTiets = new EntitySet<ChiTiet>(new Action<ChiTiet>(this.attach_ChiTiets), new Action<ChiTiet>(this.detach_ChiTiets));
			this._Phim = default(EntityRef<Phim>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_malich", DbType="Char(7) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string malich
		{
			get
			{
				return this._malich;
			}
			set
			{
				if ((this._malich != value))
				{
					this.OnmalichChanging(value);
					this.SendPropertyChanging();
					this._malich = value;
					this.SendPropertyChanged("malich");
					this.OnmalichChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_maphim", DbType="Int")]
		public System.Nullable<int> maphim
		{
			get
			{
				return this._maphim;
			}
			set
			{
				if ((this._maphim != value))
				{
					if (this._Phim.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmaphimChanging(value);
					this.SendPropertyChanging();
					this._maphim = value;
					this.SendPropertyChanged("maphim");
					this.OnmaphimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngay", DbType="Date")]
		public System.Nullable<System.DateTime> ngay
		{
			get
			{
				return this._ngay;
			}
			set
			{
				if ((this._ngay != value))
				{
					this.OnngayChanging(value);
					this.SendPropertyChanging();
					this._ngay = value;
					this.SendPropertyChanged("ngay");
					this.OnngayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gio", DbType="VarChar(5)")]
		public string gio
		{
			get
			{
				return this._gio;
			}
			set
			{
				if ((this._gio != value))
				{
					this.OngioChanging(value);
					this.SendPropertyChanging();
					this._gio = value;
					this.SendPropertyChanged("gio");
					this.OngioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> gia
		{
			get
			{
				return this._gia;
			}
			set
			{
				if ((this._gia != value))
				{
					this.OngiaChanging(value);
					this.SendPropertyChanging();
					this._gia = value;
					this.SendPropertyChanged("gia");
					this.OngiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soluong", DbType="Int")]
		public System.Nullable<int> soluong
		{
			get
			{
				return this._soluong;
			}
			set
			{
				if ((this._soluong != value))
				{
					this.OnsoluongChanging(value);
					this.SendPropertyChanging();
					this._soluong = value;
					this.SendPropertyChanged("soluong");
					this.OnsoluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LichChieu_ChiTiet", Storage="_ChiTiets", ThisKey="malich", OtherKey="malich")]
		public EntitySet<ChiTiet> ChiTiets
		{
			get
			{
				return this._ChiTiets;
			}
			set
			{
				this._ChiTiets.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Phim_LichChieu", Storage="_Phim", ThisKey="maphim", OtherKey="maphim", IsForeignKey=true)]
		public Phim Phim
		{
			get
			{
				return this._Phim.Entity;
			}
			set
			{
				Phim previousValue = this._Phim.Entity;
				if (((previousValue != value) 
							|| (this._Phim.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Phim.Entity = null;
						previousValue.LichChieus.Remove(this);
					}
					this._Phim.Entity = value;
					if ((value != null))
					{
						value.LichChieus.Add(this);
						this._maphim = value.maphim;
					}
					else
					{
						this._maphim = default(Nullable<int>);
					}
					this.SendPropertyChanged("Phim");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ChiTiets(ChiTiet entity)
		{
			this.SendPropertyChanging();
			entity.LichChieu = this;
		}
		
		private void detach_ChiTiets(ChiTiet entity)
		{
			this.SendPropertyChanging();
			entity.LichChieu = null;
		}
	}
}
#pragma warning restore 1591
