#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P04AplikacjaZawodnicy.Core.Repositories
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="A_Zawodnicy")]
	public partial class ModelBazyDanychDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertZawodnik(Zawodnik instance);
    partial void UpdateZawodnik(Zawodnik instance);
    partial void DeleteZawodnik(Zawodnik instance);
    #endregion
		
		public ModelBazyDanychDataContext() : 
				base(global::P04AplikacjaZawodnicy.Core.Properties.Settings.Default.A_ZawodnicyConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ModelBazyDanychDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModelBazyDanychDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModelBazyDanychDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModelBazyDanychDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Zawodnik> Zawodnik
		{
			get
			{
				return this.GetTable<Zawodnik>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.zawodnicy")]
	public partial class Zawodnik : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_zawodnika;
		
		private System.Nullable<int> _Id_trenera;
		
		private string _Imie;
		
		private string _Nazwisko;
		
		private string _Kraj;
		
		private System.Nullable<System.DateTime> _Data_ur;
		
		private System.Nullable<int> _Wzrost;
		
		private System.Nullable<int> _Waga;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_zawodnikaChanging(int value);
    partial void OnId_zawodnikaChanged();
    partial void OnId_treneraChanging(System.Nullable<int> value);
    partial void OnId_treneraChanged();
    partial void OnImieChanging(string value);
    partial void OnImieChanged();
    partial void OnNazwiskoChanging(string value);
    partial void OnNazwiskoChanged();
    partial void OnKrajChanging(string value);
    partial void OnKrajChanged();
    partial void OnData_urChanging(System.Nullable<System.DateTime> value);
    partial void OnData_urChanged();
    partial void OnWzrostChanging(System.Nullable<int> value);
    partial void OnWzrostChanged();
    partial void OnWagaChanging(System.Nullable<int> value);
    partial void OnWagaChanged();
    #endregion
		
		public Zawodnik()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_zawodnika", Storage="_Id_zawodnika", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_zawodnika
		{
			get
			{
				return this._Id_zawodnika;
			}
			set
			{
				if ((this._Id_zawodnika != value))
				{
					this.OnId_zawodnikaChanging(value);
					this.SendPropertyChanging();
					this._Id_zawodnika = value;
					this.SendPropertyChanged("Id_zawodnika");
					this.OnId_zawodnikaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_trenera", Storage="_Id_trenera", DbType="Int")]
		public System.Nullable<int> Id_trenera
		{
			get
			{
				return this._Id_trenera;
			}
			set
			{
				if ((this._Id_trenera != value))
				{
					this.OnId_treneraChanging(value);
					this.SendPropertyChanging();
					this._Id_trenera = value;
					this.SendPropertyChanged("Id_trenera");
					this.OnId_treneraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="imie", Storage="_Imie", DbType="VarChar(255)")]
		public string Imie
		{
			get
			{
				return this._Imie;
			}
			set
			{
				if ((this._Imie != value))
				{
					this.OnImieChanging(value);
					this.SendPropertyChanging();
					this._Imie = value;
					this.SendPropertyChanged("Imie");
					this.OnImieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="nazwisko", Storage="_Nazwisko", DbType="VarChar(255)")]
		public string Nazwisko
		{
			get
			{
				return this._Nazwisko;
			}
			set
			{
				if ((this._Nazwisko != value))
				{
					this.OnNazwiskoChanging(value);
					this.SendPropertyChanging();
					this._Nazwisko = value;
					this.SendPropertyChanged("Nazwisko");
					this.OnNazwiskoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="kraj", Storage="_Kraj", DbType="VarChar(255)")]
		public string Kraj
		{
			get
			{
				return this._Kraj;
			}
			set
			{
				if ((this._Kraj != value))
				{
					this.OnKrajChanging(value);
					this.SendPropertyChanging();
					this._Kraj = value;
					this.SendPropertyChanged("Kraj");
					this.OnKrajChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="data_ur", Storage="_Data_ur", DbType="DateTime")]
		public System.Nullable<System.DateTime> Data_ur
		{
			get
			{
				return this._Data_ur;
			}
			set
			{
				if ((this._Data_ur != value))
				{
					this.OnData_urChanging(value);
					this.SendPropertyChanging();
					this._Data_ur = value;
					this.SendPropertyChanged("Data_ur");
					this.OnData_urChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="wzrost", Storage="_Wzrost", DbType="Int")]
		public System.Nullable<int> Wzrost
		{
			get
			{
				return this._Wzrost;
			}
			set
			{
				if ((this._Wzrost != value))
				{
					this.OnWzrostChanging(value);
					this.SendPropertyChanging();
					this._Wzrost = value;
					this.SendPropertyChanged("Wzrost");
					this.OnWzrostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="waga", Storage="_Waga", DbType="Int")]
		public System.Nullable<int> Waga
		{
			get
			{
				return this._Waga;
			}
			set
			{
				if ((this._Waga != value))
				{
					this.OnWagaChanging(value);
					this.SendPropertyChanging();
					this._Waga = value;
					this.SendPropertyChanged("Waga");
					this.OnWagaChanged();
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
}
#pragma warning restore 1591
