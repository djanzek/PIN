﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("StudentiModel", "fk_kol", "kolegij", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(StudentiModel.kolegij), "student", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(StudentiModel.student), true)]

#endregion

namespace StudentiModel
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class StudentiEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new StudentiEntities object using the connection string found in the 'StudentiEntities' section of the application configuration file.
        /// </summary>
        public StudentiEntities() : base("name=StudentiEntities", "StudentiEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new StudentiEntities object.
        /// </summary>
        public StudentiEntities(string connectionString) : base(connectionString, "StudentiEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new StudentiEntities object.
        /// </summary>
        public StudentiEntities(EntityConnection connection) : base(connection, "StudentiEntities")
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
        public ObjectSet<kolegij> kolegij
        {
            get
            {
                if ((_kolegij == null))
                {
                    _kolegij = base.CreateObjectSet<kolegij>("kolegij");
                }
                return _kolegij;
            }
        }
        private ObjectSet<kolegij> _kolegij;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<student> student
        {
            get
            {
                if ((_student == null))
                {
                    _student = base.CreateObjectSet<student>("student");
                }
                return _student;
            }
        }
        private ObjectSet<student> _student;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the kolegij EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTokolegij(kolegij kolegij)
        {
            base.AddObject("kolegij", kolegij);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the student EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTostudent(student student)
        {
            base.AddObject("student", student);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="StudentiModel", Name="kolegij")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class kolegij : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new kolegij object.
        /// </summary>
        /// <param name="kol_id">Initial value of the kol_id property.</param>
        /// <param name="naziv">Initial value of the naziv property.</param>
        public static kolegij Createkolegij(global::System.Int32 kol_id, global::System.String naziv)
        {
            kolegij kolegij = new kolegij();
            kolegij.kol_id = kol_id;
            kolegij.naziv = naziv;
            return kolegij;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 kol_id
        {
            get
            {
                return _kol_id;
            }
            set
            {
                if (_kol_id != value)
                {
                    Onkol_idChanging(value);
                    ReportPropertyChanging("kol_id");
                    _kol_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("kol_id");
                    Onkol_idChanged();
                }
            }
        }
        private global::System.Int32 _kol_id;
        partial void Onkol_idChanging(global::System.Int32 value);
        partial void Onkol_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String naziv
        {
            get
            {
                return _naziv;
            }
            set
            {
                OnnazivChanging(value);
                ReportPropertyChanging("naziv");
                _naziv = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("naziv");
                OnnazivChanged();
            }
        }
        private global::System.String _naziv;
        partial void OnnazivChanging(global::System.String value);
        partial void OnnazivChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("StudentiModel", "fk_kol", "student")]
        public EntityCollection<student> student
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<student>("StudentiModel.fk_kol", "student");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<student>("StudentiModel.fk_kol", "student", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="StudentiModel", Name="student")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class student : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new student object.
        /// </summary>
        /// <param name="stud_id">Initial value of the stud_id property.</param>
        /// <param name="ime">Initial value of the ime property.</param>
        /// <param name="prezime">Initial value of the prezime property.</param>
        public static student Createstudent(global::System.Int32 stud_id, global::System.String ime, global::System.String prezime)
        {
            student student = new student();
            student.stud_id = stud_id;
            student.ime = ime;
            student.prezime = prezime;
            return student;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 stud_id
        {
            get
            {
                return _stud_id;
            }
            set
            {
                if (_stud_id != value)
                {
                    Onstud_idChanging(value);
                    ReportPropertyChanging("stud_id");
                    _stud_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("stud_id");
                    Onstud_idChanged();
                }
            }
        }
        private global::System.Int32 _stud_id;
        partial void Onstud_idChanging(global::System.Int32 value);
        partial void Onstud_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ime
        {
            get
            {
                return _ime;
            }
            set
            {
                OnimeChanging(value);
                ReportPropertyChanging("ime");
                _ime = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ime");
                OnimeChanged();
            }
        }
        private global::System.String _ime;
        partial void OnimeChanging(global::System.String value);
        partial void OnimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String prezime
        {
            get
            {
                return _prezime;
            }
            set
            {
                OnprezimeChanging(value);
                ReportPropertyChanging("prezime");
                _prezime = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("prezime");
                OnprezimeChanged();
            }
        }
        private global::System.String _prezime;
        partial void OnprezimeChanging(global::System.String value);
        partial void OnprezimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> kol_id
        {
            get
            {
                return _kol_id;
            }
            set
            {
                Onkol_idChanging(value);
                ReportPropertyChanging("kol_id");
                _kol_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("kol_id");
                Onkol_idChanged();
            }
        }
        private Nullable<global::System.Int32> _kol_id;
        partial void Onkol_idChanging(Nullable<global::System.Int32> value);
        partial void Onkol_idChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("StudentiModel", "fk_kol", "kolegij")]
        public kolegij kolegij
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<kolegij>("StudentiModel.fk_kol", "kolegij").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<kolegij>("StudentiModel.fk_kol", "kolegij").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<kolegij> kolegijReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<kolegij>("StudentiModel.fk_kol", "kolegij");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<kolegij>("StudentiModel.fk_kol", "kolegij", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
