﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace sdtime.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ConnectWiseEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ConnectWiseEntities object using the connection string found in the 'ConnectWiseEntities' section of the application configuration file.
        /// </summary>
        public ConnectWiseEntities() : base("name=ConnectWiseEntities", "ConnectWiseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ConnectWiseEntities object.
        /// </summary>
        public ConnectWiseEntities(string connectionString) : base(connectionString, "ConnectWiseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ConnectWiseEntities object.
        /// </summary>
        public ConnectWiseEntities(EntityConnection connection) : base(connection, "ConnectWiseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<somethingdigital_vTickets> somethingdigital_vTickets
        {
            get
            {
                if ((_somethingdigital_vTickets == null))
                {
                    _somethingdigital_vTickets = base.CreateObjectSet<somethingdigital_vTickets>("somethingdigital_vTickets");
                }
                return _somethingdigital_vTickets;
            }
        }
        private ObjectSet<somethingdigital_vTickets> _somethingdigital_vTickets;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the somethingdigital_vTickets EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTosomethingdigital_vTickets(somethingdigital_vTickets somethingdigital_vTickets)
        {
            base.AddObject("somethingdigital_vTickets", somethingdigital_vTickets);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ConnectWiseModel", Name="somethingdigital_vTickets")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class somethingdigital_vTickets : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new somethingdigital_vTickets object.
        /// </summary>
        /// <param name="ticketid">Initial value of the ticketid property.</param>
        /// <param name="status">Initial value of the status property.</param>
        public static somethingdigital_vTickets Createsomethingdigital_vTickets(global::System.Int32 ticketid, global::System.String status)
        {
            somethingdigital_vTickets somethingdigital_vTickets = new somethingdigital_vTickets();
            somethingdigital_vTickets.ticketid = ticketid;
            somethingdigital_vTickets.status = status;
            return somethingdigital_vTickets;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ticketid
        {
            get
            {
                return _ticketid;
            }
            set
            {
                if (_ticketid != value)
                {
                    OnticketidChanging(value);
                    ReportPropertyChanging("ticketid");
                    _ticketid = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ticketid");
                    OnticketidChanged();
                }
            }
        }
        private global::System.Int32 _ticketid;
        partial void OnticketidChanging(global::System.Int32 value);
        partial void OnticketidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Employee
        {
            get
            {
                return _Employee;
            }
            set
            {
                OnEmployeeChanging(value);
                ReportPropertyChanging("Employee");
                _Employee = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Employee");
                OnEmployeeChanged();
            }
        }
        private global::System.String _Employee;
        partial void OnEmployeeChanging(global::System.String value);
        partial void OnEmployeeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> budget
        {
            get
            {
                return _budget;
            }
            set
            {
                OnbudgetChanging(value);
                ReportPropertyChanging("budget");
                _budget = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("budget");
                OnbudgetChanged();
            }
        }
        private Nullable<global::System.Decimal> _budget;
        partial void OnbudgetChanging(Nullable<global::System.Decimal> value);
        partial void OnbudgetChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> actualHours
        {
            get
            {
                return _actualHours;
            }
            set
            {
                OnactualHoursChanging(value);
                ReportPropertyChanging("actualHours");
                _actualHours = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("actualHours");
                OnactualHoursChanged();
            }
        }
        private Nullable<global::System.Decimal> _actualHours;
        partial void OnactualHoursChanging(Nullable<global::System.Decimal> value);
        partial void OnactualHoursChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String client
        {
            get
            {
                return _client;
            }
            set
            {
                OnclientChanging(value);
                ReportPropertyChanging("client");
                _client = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("client");
                OnclientChanged();
            }
        }
        private global::System.String _client;
        partial void OnclientChanging(global::System.String value);
        partial void OnclientChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String status
        {
            get
            {
                return _status;
            }
            set
            {
                if (_status != value)
                {
                    OnstatusChanging(value);
                    ReportPropertyChanging("status");
                    _status = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("status");
                    OnstatusChanged();
                }
            }
        }
        private global::System.String _status;
        partial void OnstatusChanging(global::System.String value);
        partial void OnstatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String schedule_type_id
        {
            get
            {
                return _schedule_type_id;
            }
            set
            {
                Onschedule_type_idChanging(value);
                ReportPropertyChanging("schedule_type_id");
                _schedule_type_id = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("schedule_type_id");
                Onschedule_type_idChanged();
            }
        }
        private global::System.String _schedule_type_id;
        partial void Onschedule_type_idChanging(global::System.String value);
        partial void Onschedule_type_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> scheduleDate
        {
            get
            {
                return _scheduleDate;
            }
            set
            {
                OnscheduleDateChanging(value);
                ReportPropertyChanging("scheduleDate");
                _scheduleDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("scheduleDate");
                OnscheduleDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _scheduleDate;
        partial void OnscheduleDateChanging(Nullable<global::System.DateTime> value);
        partial void OnscheduleDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> Sort_Order
        {
            get
            {
                return _Sort_Order;
            }
            set
            {
                OnSort_OrderChanging(value);
                ReportPropertyChanging("Sort_Order");
                _Sort_Order = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Sort_Order");
                OnSort_OrderChanged();
            }
        }
        private Nullable<global::System.Int16> _Sort_Order;
        partial void OnSort_OrderChanging(Nullable<global::System.Int16> value);
        partial void OnSort_OrderChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> employeeId
        {
            get
            {
                return _employeeId;
            }
            set
            {
                OnemployeeIdChanging(value);
                ReportPropertyChanging("employeeId");
                _employeeId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("employeeId");
                OnemployeeIdChanged();
            }
        }
        private Nullable<global::System.Int32> _employeeId;
        partial void OnemployeeIdChanging(Nullable<global::System.Int32> value);
        partial void OnemployeeIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> clientId
        {
            get
            {
                return _clientId;
            }
            set
            {
                OnclientIdChanging(value);
                ReportPropertyChanging("clientId");
                _clientId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("clientId");
                OnclientIdChanged();
            }
        }
        private Nullable<global::System.Int32> _clientId;
        partial void OnclientIdChanging(Nullable<global::System.Int32> value);
        partial void OnclientIdChanged();

        #endregion

    
    }

    #endregion

    
}
