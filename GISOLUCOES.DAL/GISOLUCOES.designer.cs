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

namespace GISOLUCOES.DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="INTEGRADOSOLUCOES")]
	public partial class GISOLUCOESDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcliente(cliente instance);
    partial void Updatecliente(cliente instance);
    partial void Deletecliente(cliente instance);
    partial void Insertusuario(usuario instance);
    partial void Updateusuario(usuario instance);
    partial void Deleteusuario(usuario instance);
    #endregion
		
		public GISOLUCOESDataContext() : 
				base(global::GISOLUCOES.DAL.Properties.Settings.Default.INTEGRADOSOLUCOESConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public GISOLUCOESDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GISOLUCOESDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GISOLUCOESDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GISOLUCOESDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<cliente> clientes
		{
			get
			{
				return this.GetTable<cliente>();
			}
		}
		
		public System.Data.Linq.Table<usuario> usuarios
		{
			get
			{
				return this.GetTable<usuario>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.clientes")]
	public partial class cliente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _cnpj;
		
		private string _nome_fantasia;
		
		private string _razao_social;
		
		private string _cep;
		
		private string _endereco;
		
		private string _numero;
		
		private string _complemento;
		
		private string _bairro;
		
		private string _cidade;
		
		private string _uf;
		
		private EntitySet<usuario> _usuarios;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OncnpjChanging(string value);
    partial void OncnpjChanged();
    partial void Onnome_fantasiaChanging(string value);
    partial void Onnome_fantasiaChanged();
    partial void Onrazao_socialChanging(string value);
    partial void Onrazao_socialChanged();
    partial void OncepChanging(string value);
    partial void OncepChanged();
    partial void OnenderecoChanging(string value);
    partial void OnenderecoChanged();
    partial void OnnumeroChanging(string value);
    partial void OnnumeroChanged();
    partial void OncomplementoChanging(string value);
    partial void OncomplementoChanged();
    partial void OnbairroChanging(string value);
    partial void OnbairroChanged();
    partial void OncidadeChanging(string value);
    partial void OncidadeChanged();
    partial void OnufChanging(string value);
    partial void OnufChanged();
    #endregion
		
		public cliente()
		{
			this._usuarios = new EntitySet<usuario>(new Action<usuario>(this.attach_usuarios), new Action<usuario>(this.detach_usuarios));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cnpj", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string cnpj
		{
			get
			{
				return this._cnpj;
			}
			set
			{
				if ((this._cnpj != value))
				{
					this.OncnpjChanging(value);
					this.SendPropertyChanging();
					this._cnpj = value;
					this.SendPropertyChanged("cnpj");
					this.OncnpjChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome_fantasia", DbType="NChar(50)")]
		public string nome_fantasia
		{
			get
			{
				return this._nome_fantasia;
			}
			set
			{
				if ((this._nome_fantasia != value))
				{
					this.Onnome_fantasiaChanging(value);
					this.SendPropertyChanging();
					this._nome_fantasia = value;
					this.SendPropertyChanged("nome_fantasia");
					this.Onnome_fantasiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_razao_social", DbType="NChar(50)")]
		public string razao_social
		{
			get
			{
				return this._razao_social;
			}
			set
			{
				if ((this._razao_social != value))
				{
					this.Onrazao_socialChanging(value);
					this.SendPropertyChanging();
					this._razao_social = value;
					this.SendPropertyChanged("razao_social");
					this.Onrazao_socialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cep", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string cep
		{
			get
			{
				return this._cep;
			}
			set
			{
				if ((this._cep != value))
				{
					this.OncepChanging(value);
					this.SendPropertyChanging();
					this._cep = value;
					this.SendPropertyChanged("cep");
					this.OncepChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_endereco", DbType="NChar(50)")]
		public string endereco
		{
			get
			{
				return this._endereco;
			}
			set
			{
				if ((this._endereco != value))
				{
					this.OnenderecoChanging(value);
					this.SendPropertyChanging();
					this._endereco = value;
					this.SendPropertyChanged("endereco");
					this.OnenderecoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numero", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string numero
		{
			get
			{
				return this._numero;
			}
			set
			{
				if ((this._numero != value))
				{
					this.OnnumeroChanging(value);
					this.SendPropertyChanging();
					this._numero = value;
					this.SendPropertyChanged("numero");
					this.OnnumeroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_complemento", DbType="NChar(50)")]
		public string complemento
		{
			get
			{
				return this._complemento;
			}
			set
			{
				if ((this._complemento != value))
				{
					this.OncomplementoChanging(value);
					this.SendPropertyChanging();
					this._complemento = value;
					this.SendPropertyChanged("complemento");
					this.OncomplementoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bairro", DbType="NChar(50)")]
		public string bairro
		{
			get
			{
				return this._bairro;
			}
			set
			{
				if ((this._bairro != value))
				{
					this.OnbairroChanging(value);
					this.SendPropertyChanging();
					this._bairro = value;
					this.SendPropertyChanged("bairro");
					this.OnbairroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cidade", DbType="NChar(50)")]
		public string cidade
		{
			get
			{
				return this._cidade;
			}
			set
			{
				if ((this._cidade != value))
				{
					this.OncidadeChanging(value);
					this.SendPropertyChanging();
					this._cidade = value;
					this.SendPropertyChanged("cidade");
					this.OncidadeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uf", DbType="NChar(50)")]
		public string uf
		{
			get
			{
				return this._uf;
			}
			set
			{
				if ((this._uf != value))
				{
					this.OnufChanging(value);
					this.SendPropertyChanging();
					this._uf = value;
					this.SendPropertyChanged("uf");
					this.OnufChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cliente_usuario", Storage="_usuarios", ThisKey="id", OtherKey="cliente_id")]
		public EntitySet<usuario> usuarios
		{
			get
			{
				return this._usuarios;
			}
			set
			{
				this._usuarios.Assign(value);
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
		
		private void attach_usuarios(usuario entity)
		{
			this.SendPropertyChanging();
			entity.cliente = this;
		}
		
		private void detach_usuarios(usuario entity)
		{
			this.SendPropertyChanging();
			entity.cliente = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.usuarios")]
	public partial class usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _cliente_id;
		
		private string _nome;
		
		private string _sobrenome;
		
		private string _telefone;
		
		private string _email;
		
		private string _senha;
		
		private EntityRef<cliente> _cliente;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Oncliente_idChanging(System.Nullable<int> value);
    partial void Oncliente_idChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OnsobrenomeChanging(string value);
    partial void OnsobrenomeChanged();
    partial void OntelefoneChanging(string value);
    partial void OntelefoneChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnsenhaChanging(string value);
    partial void OnsenhaChanged();
    #endregion
		
		public usuario()
		{
			this._cliente = default(EntityRef<cliente>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cliente_id", DbType="Int")]
		public System.Nullable<int> cliente_id
		{
			get
			{
				return this._cliente_id;
			}
			set
			{
				if ((this._cliente_id != value))
				{
					if (this._cliente.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oncliente_idChanging(value);
					this.SendPropertyChanging();
					this._cliente_id = value;
					this.SendPropertyChanged("cliente_id");
					this.Oncliente_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="NChar(50)")]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sobrenome", DbType="NChar(50)")]
		public string sobrenome
		{
			get
			{
				return this._sobrenome;
			}
			set
			{
				if ((this._sobrenome != value))
				{
					this.OnsobrenomeChanging(value);
					this.SendPropertyChanging();
					this._sobrenome = value;
					this.SendPropertyChanged("sobrenome");
					this.OnsobrenomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefone", DbType="VarChar(30)")]
		public string telefone
		{
			get
			{
				return this._telefone;
			}
			set
			{
				if ((this._telefone != value))
				{
					this.OntelefoneChanging(value);
					this.SendPropertyChanging();
					this._telefone = value;
					this.SendPropertyChanged("telefone");
					this.OntelefoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_senha", DbType="NChar(50)")]
		public string senha
		{
			get
			{
				return this._senha;
			}
			set
			{
				if ((this._senha != value))
				{
					this.OnsenhaChanging(value);
					this.SendPropertyChanging();
					this._senha = value;
					this.SendPropertyChanged("senha");
					this.OnsenhaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cliente_usuario", Storage="_cliente", ThisKey="cliente_id", OtherKey="id", IsForeignKey=true)]
		public cliente cliente
		{
			get
			{
				return this._cliente.Entity;
			}
			set
			{
				cliente previousValue = this._cliente.Entity;
				if (((previousValue != value) 
							|| (this._cliente.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._cliente.Entity = null;
						previousValue.usuarios.Remove(this);
					}
					this._cliente.Entity = value;
					if ((value != null))
					{
						value.usuarios.Add(this);
						this._cliente_id = value.id;
					}
					else
					{
						this._cliente_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("cliente");
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
