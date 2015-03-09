﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGTE_Repositorio
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SGTE2")]
	public partial class SGTEDATADataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTbl_Funcionario(Tbl_Funcionario instance);
    partial void UpdateTbl_Funcionario(Tbl_Funcionario instance);
    partial void DeleteTbl_Funcionario(Tbl_Funcionario instance);
    #endregion
		
		public SGTEDATADataContext() : 
				base(global::SGTE_Repositorio.Properties.Settings.Default.SGTE2ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SGTEDATADataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SGTEDATADataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SGTEDATADataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SGTEDATADataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Tbl_Funcionario> Tbl_Funcionarios
		{
			get
			{
				return this.GetTable<Tbl_Funcionario>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.stp_CadastroFuncionario")]
		public ISingleResult<stp_CadastroFuncionarioResult> stp_CadastroFuncionario(
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ID", DbType="Int")] System.Nullable<int> iD, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Funcao", DbType="VarChar(80)")] string funcao, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Matricula", DbType="Int")] System.Nullable<int> matricula, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nome", DbType="VarChar(80)")] string nome, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Endereco", DbType="VarChar(240)")] string endereco, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Bairro", DbType="VarChar(40)")] string bairro, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Cidade", DbType="VarChar(40)")] string cidade, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CEP", DbType="VarChar(10)")] string cEP, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Estado", DbType="VarChar(2)")] string estado, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Tel_Residencial", DbType="VarChar(80)")] string tel_Residencial, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Tel_Celular", DbType="VarChar(80)")] string tel_Celular, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(80)")] string email, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="RG", DbType="VarChar(9)")] string rG, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CPF", DbType="VarChar(11)")] string cPF, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Data_Nasc", DbType="DateTime")] System.Nullable<System.DateTime> data_Nasc, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Sexo", DbType="VarChar(1)")] string sexo, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="NivelAcesso", DbType="Int")] System.Nullable<int> nivelAcesso, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nivel", DbType="Int")] System.Nullable<int> nivel, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Mensagem", DbType="VarChar(20)")] string mensagem)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iD, funcao, matricula, nome, endereco, bairro, cidade, cEP, estado, tel_Residencial, tel_Celular, email, rG, cPF, data_Nasc, sexo, nivelAcesso, nivel, mensagem);
			return ((ISingleResult<stp_CadastroFuncionarioResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_Funcionario")]
	public partial class Tbl_Funcionario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Funcao;
		
		private int _Matricula;
		
		private string _Nome;
		
		private string _Endereco;
		
		private string _Bairro;
		
		private string _Cidade;
		
		private string _CEP;
		
		private string _Estado;
		
		private string _Tel_Residencial;
		
		private string _Tel_Celular;
		
		private string _Email;
		
		private string _RG;
		
		private string _CPF;
		
		private System.DateTime _Data_Nasc;
		
		private string _Sexo;
		
		private System.Nullable<int> _Ativo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFuncaoChanging(string value);
    partial void OnFuncaoChanged();
    partial void OnMatriculaChanging(int value);
    partial void OnMatriculaChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnEnderecoChanging(string value);
    partial void OnEnderecoChanged();
    partial void OnBairroChanging(string value);
    partial void OnBairroChanged();
    partial void OnCidadeChanging(string value);
    partial void OnCidadeChanged();
    partial void OnCEPChanging(string value);
    partial void OnCEPChanged();
    partial void OnEstadoChanging(string value);
    partial void OnEstadoChanged();
    partial void OnTel_ResidencialChanging(string value);
    partial void OnTel_ResidencialChanged();
    partial void OnTel_CelularChanging(string value);
    partial void OnTel_CelularChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnRGChanging(string value);
    partial void OnRGChanged();
    partial void OnCPFChanging(string value);
    partial void OnCPFChanged();
    partial void OnData_NascChanging(System.DateTime value);
    partial void OnData_NascChanged();
    partial void OnSexoChanging(string value);
    partial void OnSexoChanged();
    partial void OnAtivoChanging(System.Nullable<int> value);
    partial void OnAtivoChanged();
    #endregion
		
		public Tbl_Funcionario()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Funcao", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
		public string Funcao
		{
			get
			{
				return this._Funcao;
			}
			set
			{
				if ((this._Funcao != value))
				{
					this.OnFuncaoChanging(value);
					this.SendPropertyChanging();
					this._Funcao = value;
					this.SendPropertyChanged("Funcao");
					this.OnFuncaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Matricula", DbType="Int NOT NULL")]
		public int Matricula
		{
			get
			{
				return this._Matricula;
			}
			set
			{
				if ((this._Matricula != value))
				{
					this.OnMatriculaChanging(value);
					this.SendPropertyChanging();
					this._Matricula = value;
					this.SendPropertyChanged("Matricula");
					this.OnMatriculaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Endereco", DbType="VarChar(240) NOT NULL", CanBeNull=false)]
		public string Endereco
		{
			get
			{
				return this._Endereco;
			}
			set
			{
				if ((this._Endereco != value))
				{
					this.OnEnderecoChanging(value);
					this.SendPropertyChanging();
					this._Endereco = value;
					this.SendPropertyChanged("Endereco");
					this.OnEnderecoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bairro", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string Bairro
		{
			get
			{
				return this._Bairro;
			}
			set
			{
				if ((this._Bairro != value))
				{
					this.OnBairroChanging(value);
					this.SendPropertyChanging();
					this._Bairro = value;
					this.SendPropertyChanged("Bairro");
					this.OnBairroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cidade", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string Cidade
		{
			get
			{
				return this._Cidade;
			}
			set
			{
				if ((this._Cidade != value))
				{
					this.OnCidadeChanging(value);
					this.SendPropertyChanging();
					this._Cidade = value;
					this.SendPropertyChanged("Cidade");
					this.OnCidadeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CEP", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string CEP
		{
			get
			{
				return this._CEP;
			}
			set
			{
				if ((this._CEP != value))
				{
					this.OnCEPChanging(value);
					this.SendPropertyChanging();
					this._CEP = value;
					this.SendPropertyChanged("CEP");
					this.OnCEPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estado", DbType="VarChar(2) NOT NULL", CanBeNull=false)]
		public string Estado
		{
			get
			{
				return this._Estado;
			}
			set
			{
				if ((this._Estado != value))
				{
					this.OnEstadoChanging(value);
					this.SendPropertyChanging();
					this._Estado = value;
					this.SendPropertyChanged("Estado");
					this.OnEstadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tel_Residencial", DbType="VarChar(80)")]
		public string Tel_Residencial
		{
			get
			{
				return this._Tel_Residencial;
			}
			set
			{
				if ((this._Tel_Residencial != value))
				{
					this.OnTel_ResidencialChanging(value);
					this.SendPropertyChanging();
					this._Tel_Residencial = value;
					this.SendPropertyChanged("Tel_Residencial");
					this.OnTel_ResidencialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tel_Celular", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
		public string Tel_Celular
		{
			get
			{
				return this._Tel_Celular;
			}
			set
			{
				if ((this._Tel_Celular != value))
				{
					this.OnTel_CelularChanging(value);
					this.SendPropertyChanging();
					this._Tel_Celular = value;
					this.SendPropertyChanged("Tel_Celular");
					this.OnTel_CelularChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RG", DbType="VarChar(9) NOT NULL", CanBeNull=false)]
		public string RG
		{
			get
			{
				return this._RG;
			}
			set
			{
				if ((this._RG != value))
				{
					this.OnRGChanging(value);
					this.SendPropertyChanging();
					this._RG = value;
					this.SendPropertyChanged("RG");
					this.OnRGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPF", DbType="VarChar(11) NOT NULL", CanBeNull=false)]
		public string CPF
		{
			get
			{
				return this._CPF;
			}
			set
			{
				if ((this._CPF != value))
				{
					this.OnCPFChanging(value);
					this.SendPropertyChanging();
					this._CPF = value;
					this.SendPropertyChanged("CPF");
					this.OnCPFChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Data_Nasc", DbType="DateTime NOT NULL")]
		public System.DateTime Data_Nasc
		{
			get
			{
				return this._Data_Nasc;
			}
			set
			{
				if ((this._Data_Nasc != value))
				{
					this.OnData_NascChanging(value);
					this.SendPropertyChanging();
					this._Data_Nasc = value;
					this.SendPropertyChanged("Data_Nasc");
					this.OnData_NascChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sexo", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string Sexo
		{
			get
			{
				return this._Sexo;
			}
			set
			{
				if ((this._Sexo != value))
				{
					this.OnSexoChanging(value);
					this.SendPropertyChanging();
					this._Sexo = value;
					this.SendPropertyChanged("Sexo");
					this.OnSexoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ativo", DbType="Int")]
		public System.Nullable<int> Ativo
		{
			get
			{
				return this._Ativo;
			}
			set
			{
				if ((this._Ativo != value))
				{
					this.OnAtivoChanging(value);
					this.SendPropertyChanging();
					this._Ativo = value;
					this.SendPropertyChanged("Ativo");
					this.OnAtivoChanged();
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
	
	public partial class stp_CadastroFuncionarioResult
	{
		
		private string _Mensagem;
		
		public stp_CadastroFuncionarioResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mensagem", DbType="VarChar(36) NOT NULL", CanBeNull=false)]
		public string Mensagem
		{
			get
			{
				return this._Mensagem;
			}
			set
			{
				if ((this._Mensagem != value))
				{
					this._Mensagem = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
