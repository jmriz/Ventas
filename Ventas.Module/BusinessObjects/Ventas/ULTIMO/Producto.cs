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
    public class Producto : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Producto(Session session)
            : base(session)
        {
        }
        

        #region Propiedades

        private string _Nombre;
        private string _Descripcion;
        private decimal _PrecioUnitario;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Nombre
        {
            get { return _Nombre; }
            set { SetPropertyValue(nameof(Nombre), ref _Nombre, value); }
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Descripcion
        {
            get { return _Descripcion; }
            set { SetPropertyValue(nameof(Descripcion), ref _Descripcion, value); }
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]

        public decimal PrecioUnitario
        {
            get { return _PrecioUnitario; }
            set { SetPropertyValue(nameof(PrecioUnitario), ref _PrecioUnitario, value); }
        }

        #endregion Propiedades


        #region Colecciones

        #endregion Colecciones


        #region Métodos redefinidos

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        #endregion Métodos redefinidos


        #region Métodos

        #endregion Métodos
    }
}