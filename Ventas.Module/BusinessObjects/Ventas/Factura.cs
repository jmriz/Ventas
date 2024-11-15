using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using DevExpress.XtraScheduler.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Ventas.Module.BusinessObjects.Ventas
{
    [DefaultClassOptions]
    [NavigationItem("VENTAS")]
    [DefaultProperty("Factura")]

    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Factura : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Factura(Session session)
            : base(session)
        {
        }

        #region Propiedades

        private DateTime _Fecha;
        private Cliente _Cliente;
        private string _Dni;
        private decimal _TotalFactura;
        private Operacion _Operacion;


        [RuleRequiredField(DefaultContexts.Save)]
        public DateTime Fecha
        {
            get { return _Fecha; }
            set { SetPropertyValue(nameof(Fecha), ref _Fecha, value); }
        }

        [Association("Cliente-Facturas")]

        public Cliente Cliente
        {
            get { return _Cliente; }
            set { SetPropertyValue(nameof(Cliente), ref _Cliente, value); }
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]

        public string Dni
        {
            get { return _Dni; }
            set { SetPropertyValue(nameof(Dni), ref _Dni, value); }
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]

        public decimal TotalFactura
        {
            get { return _TotalFactura; }
            set { SetPropertyValue(nameof(TotalFactura), ref _TotalFactura, value); }
        }

        #endregion Propiedades


        #region Colecciones

        // Asociaciones

        [Association("Factura-FacturaDetalles")]
        public XPCollection<FacturaDetalle> FacturaDetalles
        {
            get { return GetCollection<FacturaDetalle>("FacturaDetalles"); }
        }



        [Association("Operacion-Facturas")]

        public Operacion Operacion
        {
            get { return _Operacion; }
            set { SetPropertyValue(nameof(Operacion), ref _Operacion, value); }
        }



        #endregion Colecciones


        #region Métodos redefinidos

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            this.Fecha = DateTime.Now;
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }


        protected override void OnSaving()
        {
            base.OnSaving();

            CalcularTotalFactura();
        }


        protected override void OnChanged(String propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);
            if (propertyName == "Cliente")
            {
                if (!ReferenceEquals(null, this.Cliente))

                {
                    this.Dni = this.Cliente.Dni;
                }
                else
                {
                    this.Dni = string.Empty;
                }
            }

        }

        #endregion Métodos redefinidos


        #region Metodos

        public void CalcularTotalFactura()
        {
            decimal _Total = 0;
            try
            {
                foreach (var FacturaDetalle in FacturaDetalles)
                {
                    _Total += FacturaDetalle.Total;
                }
                TotalFactura = _Total;
            }
            catch
            {
                TotalFactura = 0;
            }
        }


        #endregion Metodos

    }
}