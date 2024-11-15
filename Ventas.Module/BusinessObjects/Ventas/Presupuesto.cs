using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Ventas.Module.BusinessObjects.Ventas
{
    [DefaultClassOptions]
    [NavigationItem("VENTAS")]
    [DefaultProperty("Nombre")]

    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Presupuesto : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Presupuesto(Session session)
            : base(session)
        {
        }

        #region Propiedades

        private string _Nombre;
        private string _Correo;
        private string _Cp;
        private string _Telefono;
        private DateTime _Fecha;


        [XafDisplayName("Nombre"), ToolTip("Nombre")]
        [RuleRequiredField] // Campo OBLIGATORIO

        public string Nombre
        {
            get { return _Nombre; }
            set { SetPropertyValue(nameof(Nombre), ref _Nombre, value); }
        }


        [XafDisplayName("Correo"), ToolTip("Correo electrónico")]
        [RuleRequiredField] // Campo OBLIGATORIO


        public string Correo
        {
            get { return _Correo; }
            set { SetPropertyValue(nameof(Correo), ref _Correo, value); }
        }


        [XafDisplayName("Cp"), ToolTip("Código Postal")]
        [RuleRequiredField] // Campo OBLIGATORIO

        public string Cp
        {
            get { return _Cp; }
            set { SetPropertyValue(nameof(Cp), ref _Cp, value); }
        }



        [XafDisplayName("Teléfono"), ToolTip("Teléfono")]
        [RuleRequiredField] // Campo OBLIGATORIO

        public string Telefono
        {
            get { return _Telefono; }
            set { SetPropertyValue(nameof(Telefono), ref _Telefono, value); }
        }



        [XafDisplayName("Fecha"), ToolTip("Fecha de la factura")]
        [RuleRequiredField] // Campo OBLIGATORIO

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { SetPropertyValue(nameof(Fecha), ref _Fecha, value); }
        }

        #endregion

        // Asociaciones

        #region Relaciones

        #endregion Relaciones

        #region Colecciones

        #endregion Colecciones


        #region Métodos redefinidos

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        #endregion Métodos redefinidos


        #region Metodos

        #endregion Metodos

    }
}