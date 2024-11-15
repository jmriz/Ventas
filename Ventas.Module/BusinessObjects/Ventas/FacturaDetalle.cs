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
    //[DefaultClassOptions]
    //[NavigationItem("VENTAS")]

    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class FacturaDetalle : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public FacturaDetalle(Session session)
            : base(session)
        {
        }

        #region Propiedades

        private Producto _Producto;
        private int _Cantidad;
        private decimal _Total;
        private decimal _PrecioUnitario;
        private Factura _Factura;


        public Producto Producto
        {
            get { return _Producto; }
            set { SetPropertyValue(nameof(Producto), ref _Producto, value); }
        }


        public int Cantidad
        {
            get { return _Cantidad; }
            set { SetPropertyValue(nameof(Cantidad), ref _Cantidad, value); }
        }


        public decimal Total
        {
            get { return _Total; }
            set { SetPropertyValue(nameof(Total), ref _Total, value); }
        }


        public decimal PrecioUnitario
        {
            get { return _PrecioUnitario; }
            set { SetPropertyValue(nameof(PrecioUnitario), ref _PrecioUnitario, value); }
        }


        // Asociaciones

        [Association("Factura-FacturaDetalles")]

        public Factura Factura
        {
            get { return _Factura; }
            set { SetPropertyValue(nameof(Factura), ref _Factura, value); }
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


        protected override void OnChanged(String propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);
            if (propertyName == "Producto")
            {
                if (!ReferenceEquals(null, this.Producto))

                {
                    this.PrecioUnitario = this.Producto.PrecioUnitario;
                }
            }
            if (propertyName == "Cantidad" || propertyName == "PrecioUnitario")
            {
                this.Total = this.PrecioUnitario * this.Cantidad;
            }
        }

        protected override void OnSaving()
        {
            base.OnSaving();

            Factura.Save();
        }

        #endregion Métodos redefinidos

    }
}