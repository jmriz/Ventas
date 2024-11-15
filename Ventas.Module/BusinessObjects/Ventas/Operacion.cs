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
    [DefaultProperty("Fecha")]

    //[ImageName("BO_Contact")] 
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Operacion : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Operacion(Session session)
            : base(session)
        {
        }

        #region Propiedades

        private decimal _Importe;
        private string _Nombre_apellidos;
        private string _Direccion_fact;
        private string _Direccion_env;
        private string _Correo;
        private DateTime _Fecha;
        private string _Nombre_tarjeta;
        private string _Numero_tarjeta;
        private string _Mes_caducidad;
        private string _Ano_caducidad;
        private string _Cvv;


        [XafDisplayName("Importe"), ToolTip("Importe Neto")]
        [RuleRequiredField] // Campo OBLIGATORIO

        public decimal Importe
        {
            get { return _Importe; }
            set { SetPropertyValue(nameof(Importe), ref _Importe, value); }
        }


        [XafDisplayName("Nombre y Apellidos"), ToolTip("Nombre y apellidos")]
        [RuleRequiredField] // Campo OBLIGATORIO

        public string Nombre_apellidos
        {
            get { return _Nombre_apellidos; }
            set { SetPropertyValue(nameof(Nombre_apellidos), ref _Nombre_apellidos, value); }
        }



        [XafDisplayName("Dirección de facturacion"), ToolTip("Direccion de facturación")]
        [RuleRequiredField] // Campo OBLIGATORIO

        public string Direccion_fact
        {
            get { return _Direccion_fact; }
            set { SetPropertyValue(nameof(Direccion_fact), ref _Direccion_fact, value); }
        }



        [XafDisplayName("Dirección de envio"), ToolTip("Direccion de envio")]

        public string Direccion_env
        {
            get { return _Direccion_env; }
            set { SetPropertyValue(nameof(Direccion_env), ref _Direccion_env, value); }
        }



        [XafDisplayName("Correo"), ToolTip("Correo electrónico")]
        [RuleRequiredField] // Campo OBLIGATORIO

        public string Correo
        {
            get { return _Correo; }
            set { SetPropertyValue(nameof(Correo), ref _Correo, value); }
        }



        [XafDisplayName("Fecha"), ToolTip("Fecha de la factura")]
        [RuleRequiredField] // Campo OBLIGATORIO

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { SetPropertyValue(nameof(Fecha), ref _Fecha, value); }
        }



        [XafDisplayName("Nombre Tarjeta"), ToolTip("Nombre de tarjeta")]
        [RuleRequiredField] // Campo OBLIGATORIO

        public string Nombre_tarjeta
        {
            get { return _Nombre_tarjeta; }
            set { SetPropertyValue(nameof(Nombre_tarjeta), ref _Nombre_tarjeta, value); }
        }



        [XafDisplayName("Numero Tarjeta"), ToolTip("Número de tarjeta")]
        [RuleRequiredField] // Campo OBLIGATORIO

        public string Numero_tarjeta
        {
            get { return _Numero_tarjeta; }
            set { SetPropertyValue(nameof(Numero_tarjeta), ref _Numero_tarjeta, value); }
        }



        [XafDisplayName("Mes de caducidad"), ToolTip("Mes de caucidad de la tarjeta")]
        [RuleRequiredField] // Campo OBLIGATORIO

        public string Mes_caducidad
        {
            get { return _Mes_caducidad; }
            set { SetPropertyValue(nameof(Mes_caducidad), ref _Mes_caducidad, value); }
        }



        [XafDisplayName("Año de caducidad"), ToolTip("Año de caucidad de la tarjeta ")]
        [RuleRequiredField] // Campo OBLIGATORIO

        public string Ano_caducidad
        {
            get { return _Ano_caducidad; }
            set { SetPropertyValue(nameof(Ano_caducidad), ref _Ano_caducidad, value); }
        }



        [XafDisplayName("Cvv"), ToolTip("Cvv de la tarjeta ")]
        [RuleRequiredField] // Campo OBLIGATORIO

        public string Cvv
        {
            get { return _Cvv; }
            set { SetPropertyValue(nameof(Cvv), ref _Cvv, value); }
        }

        #endregion Propiedades


        #region Relaciones

        // Asociaciones

        #endregion Relaciones


        #region Colecciones

        // Asociaciones

        [Association("Operacion-Facturas")]
        public XPCollection<Factura> Facturas
        {
            get { return GetCollection<Factura>("Facturas"); }
        }

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