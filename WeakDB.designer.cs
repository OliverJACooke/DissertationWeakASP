﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dissertation__Weak_
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WeakDB")]
	public partial class WeakDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblUser(tblUser instance);
    partial void UpdatetblUser(tblUser instance);
    partial void DeletetblUser(tblUser instance);
    partial void InserttblMessage(tblMessage instance);
    partial void UpdatetblMessage(tblMessage instance);
    partial void DeletetblMessage(tblMessage instance);
    #endregion
		
		public WeakDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WeakDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WeakDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WeakDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WeakDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WeakDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblUser> tblUsers
		{
			get
			{
				return this.GetTable<tblUser>();
			}
		}
		
		public System.Data.Linq.Table<tblMessage> tblMessages
		{
			get
			{
				return this.GetTable<tblMessage>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblUser")]
	public partial class tblUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _userID;
		
		private string _username;
		
		private string _password;
		
		private string _firstName;
		
		private string _lastName;
		
		private string _DOB;
		
		private string _eMail;
		
		private System.Nullable<int> _admin;
		
		private EntitySet<tblMessage> _tblMessages;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserIDChanging(int value);
    partial void OnuserIDChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnfirstNameChanging(string value);
    partial void OnfirstNameChanged();
    partial void OnlastNameChanging(string value);
    partial void OnlastNameChanged();
    partial void OnDOBChanging(string value);
    partial void OnDOBChanged();
    partial void OneMailChanging(string value);
    partial void OneMailChanged();
    partial void OnadminChanging(System.Nullable<int> value);
    partial void OnadminChanged();
    #endregion
		
		public tblUser()
		{
			this._tblMessages = new EntitySet<tblMessage>(new Action<tblMessage>(this.attach_tblMessages), new Action<tblMessage>(this.detach_tblMessages));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstName", DbType="VarChar(50)")]
		public string firstName
		{
			get
			{
				return this._firstName;
			}
			set
			{
				if ((this._firstName != value))
				{
					this.OnfirstNameChanging(value);
					this.SendPropertyChanging();
					this._firstName = value;
					this.SendPropertyChanged("firstName");
					this.OnfirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastName", DbType="VarChar(50)")]
		public string lastName
		{
			get
			{
				return this._lastName;
			}
			set
			{
				if ((this._lastName != value))
				{
					this.OnlastNameChanging(value);
					this.SendPropertyChanging();
					this._lastName = value;
					this.SendPropertyChanged("lastName");
					this.OnlastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="VarChar(50)")]
		public string DOB
		{
			get
			{
				return this._DOB;
			}
			set
			{
				if ((this._DOB != value))
				{
					this.OnDOBChanging(value);
					this.SendPropertyChanging();
					this._DOB = value;
					this.SendPropertyChanged("DOB");
					this.OnDOBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eMail", DbType="VarChar(50)")]
		public string eMail
		{
			get
			{
				return this._eMail;
			}
			set
			{
				if ((this._eMail != value))
				{
					this.OneMailChanging(value);
					this.SendPropertyChanging();
					this._eMail = value;
					this.SendPropertyChanged("eMail");
					this.OneMailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_admin", DbType="Int")]
		public System.Nullable<int> admin
		{
			get
			{
				return this._admin;
			}
			set
			{
				if ((this._admin != value))
				{
					this.OnadminChanging(value);
					this.SendPropertyChanging();
					this._admin = value;
					this.SendPropertyChanged("admin");
					this.OnadminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblUser_tblMessage", Storage="_tblMessages", ThisKey="userID", OtherKey="userID")]
		public EntitySet<tblMessage> tblMessages
		{
			get
			{
				return this._tblMessages;
			}
			set
			{
				this._tblMessages.Assign(value);
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
		
		private void attach_tblMessages(tblMessage entity)
		{
			this.SendPropertyChanging();
			entity.tblUser = this;
		}
		
		private void detach_tblMessages(tblMessage entity)
		{
			this.SendPropertyChanging();
			entity.tblUser = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblMessage")]
	public partial class tblMessage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _messageID;
		
		private System.Nullable<int> _userID;
		
		private string _messageBody;
		
		private System.Nullable<bool> _messageType;
		
		private string _username;
		
		private EntityRef<tblUser> _tblUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmessageIDChanging(int value);
    partial void OnmessageIDChanged();
    partial void OnuserIDChanging(System.Nullable<int> value);
    partial void OnuserIDChanged();
    partial void OnmessageBodyChanging(string value);
    partial void OnmessageBodyChanged();
    partial void OnmessageTypeChanging(System.Nullable<bool> value);
    partial void OnmessageTypeChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    #endregion
		
		public tblMessage()
		{
			this._tblUser = default(EntityRef<tblUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_messageID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int messageID
		{
			get
			{
				return this._messageID;
			}
			set
			{
				if ((this._messageID != value))
				{
					this.OnmessageIDChanging(value);
					this.SendPropertyChanging();
					this._messageID = value;
					this.SendPropertyChanged("messageID");
					this.OnmessageIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="Int")]
		public System.Nullable<int> userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					if (this._tblUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_messageBody", DbType="VarChar(MAX)")]
		public string messageBody
		{
			get
			{
				return this._messageBody;
			}
			set
			{
				if ((this._messageBody != value))
				{
					this.OnmessageBodyChanging(value);
					this.SendPropertyChanging();
					this._messageBody = value;
					this.SendPropertyChanged("messageBody");
					this.OnmessageBodyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_messageType", DbType="Bit")]
		public System.Nullable<bool> messageType
		{
			get
			{
				return this._messageType;
			}
			set
			{
				if ((this._messageType != value))
				{
					this.OnmessageTypeChanging(value);
					this.SendPropertyChanging();
					this._messageType = value;
					this.SendPropertyChanged("messageType");
					this.OnmessageTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblUser_tblMessage", Storage="_tblUser", ThisKey="userID", OtherKey="userID", IsForeignKey=true)]
		public tblUser tblUser
		{
			get
			{
				return this._tblUser.Entity;
			}
			set
			{
				tblUser previousValue = this._tblUser.Entity;
				if (((previousValue != value) 
							|| (this._tblUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblUser.Entity = null;
						previousValue.tblMessages.Remove(this);
					}
					this._tblUser.Entity = value;
					if ((value != null))
					{
						value.tblMessages.Add(this);
						this._userID = value.userID;
					}
					else
					{
						this._userID = default(Nullable<int>);
					}
					this.SendPropertyChanged("tblUser");
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
