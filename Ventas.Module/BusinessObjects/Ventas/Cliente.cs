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
    public class Cliente : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Cliente(Session session)
            : base(session)
        {
        }

        #region Propiedades

        private string _Nombre;
        private string _Dni;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]

        public string Nombre
        {
            get { return _Nombre; }
            set { SetPropertyValue(nameof(Nombre), ref _Nombre, value); }
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]

        public string Dni
        {
            get { return _Dni; }
            set { SetPropertyValue(nameof(Dni), ref _Dni, value); }
        }

        #endregion Propiedades


        #region Colecciones

        // Asociaciones


        [Association("Cliente-Facturas")]

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