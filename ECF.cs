using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsFactElect.NCF.E31
{
	// using System.Xml.Serialization;
	// XmlSerializer serializer = new XmlSerializer(typeof(ECF));
	// using (StringReader reader = new StringReader(xml))
	// {
	//    var test = (ECF)serializer.Deserialize(reader);
	// }

	public class FormaDePago
	{
		public int FormaPago { get; set; }
		public int MontoPago { get; set; }
	}

	public class TablaFormasPago
	{
		public List<FormaDePago> FormaDePago { get; set; }
	}

	public class IdDoc
	{
		public int TipoeCF { get; set; }
		public string ENCF { get; set; }
		public string FechaVencimientoSecuencia { get; set; }
		public int IndicadorEnvioDiferido { get; set; }
		public int IndicadorMontoGravado { get; set; }
		public int TipoIngresos { get; set; }
		public int TipoPago { get; set; }
		public string FechaLimitePago { get; set; }
		public string TerminoPago { get; set; }
		public TablaFormasPago TablaFormasPago { get; set; }
		public string TipoCuentaPago { get; set; }
		public string NumeroCuentaPago { get; set; }
		public string BancoPago { get; set; }
		public string FechaDesde { get; set; }
		public string FechaHasta { get; set; }
		public int TotalPaginas { get; set; }
	}

	public class TablaTelefonoEmisor
	{
		public List<string> TelefonoEmisor { get; set; }
	}

	public class Emisor
	{
		public int RNCEmisor { get; set; }
		public string RazonSocialEmisor { get; set; }
		public string NombreComercial { get; set; }
		public string Sucursal { get; set; }
		public string DireccionEmisor { get; set; }
		public int Municipio { get; set; }
		public int Provincia { get; set; }
		public TablaTelefonoEmisor TablaTelefonoEmisor { get; set; }
		public string CorreoEmisor { get; set; }
		public string WebSite { get; set; }
		public string ActividadEconomica { get; set; }
		public string CodigoVendedor { get; set; }
		public string NumeroFacturaInterna { get; set; }
		public int NumeroPedidoInterno { get; set; }
		public string ZonaVenta { get; set; }
		public string RutaVenta { get; set; }
		public string InformacionAdicionalEmisor { get; set; }
		public string FechaEmision { get; set; }
	}

	public class Comprador
	{
		public int RNCComprador { get; set; }
		public string RazonSocialComprador { get; set; }
		public string ContactoComprador { get; set; }
		public string CorreoComprador { get; set; }
		public string DireccionComprador { get; set; }
		public int MunicipioComprador { get; set; }
		public int ProvinciaComprador { get; set; }
		public string FechaEntrega { get; set; }
		public string ContactoEntrega { get; set; }
		public string DireccionEntrega { get; set; }
		public string TelefonoAdicional { get; set; }
		public string FechaOrdenCompra { get; set; }
		public string NumeroOrdenCompra { get; set; }
		public string CodigoInternoComprador { get; set; }
		public string ResponsablePago { get; set; }
		public string InformacionAdicionalComprador { get; set; }
	}

	public class InformacionesAdicionales
	{
		public string FechaEmbarque { get; set; }
		public string NumeroEmbarque { get; set; }
		public string NumeroContenedor { get; set; }
		public int NumeroReferencia { get; set; }
		public int PesoBruto { get; set; }
		public int PesoNeto { get; set; }
		public int UnidadPesoBruto { get; set; }
		public int UnidadPesoNeto { get; set; }
		public int CantidadBulto { get; set; }
		public int UnidadBulto { get; set; }
		public int VolumenBulto { get; set; }
		public int UnidadVolumen { get; set; }
	}

	public class Transporte
	{
		public string Conductor { get; set; }
		public int DocumentoTransporte { get; set; }
		public string Ficha { get; set; }
		public string Placa { get; set; }
		public string RutaTransporte { get; set; }
		public string ZonaTransporte { get; set; }
		public string NumeroAlbaran { get; set; }
	}

	public class ImpuestoAdicional
	{
		public int TipoImpuesto { get; set; }
		public int TasaImpuestoAdicional { get; set; }
		public int MontoImpuestoSelectivoConsumoEspecifico { get; set; }
		public int MontoImpuestoSelectivoConsumoAdvalorem { get; set; }
		public int OtrosImpuestosAdicionales { get; set; }
	}

	public class ImpuestosAdicionales
	{
		public List<ImpuestoAdicional> ImpuestoAdicional { get; set; }
	}

	public class Totales
	{
		public int MontoGravadoTotal { get; set; }
		public int MontoGravadoI1 { get; set; }
		public int MontoGravadoI2 { get; set; }
		public int MontoGravadoI3 { get; set; }
		public int MontoExento { get; set; }
		public int ITBIS1 { get; set; }
		public int ITBIS2 { get; set; }
		public int ITBIS3 { get; set; }
		public int TotalITBIS { get; set; }
		public int TotalITBIS1 { get; set; }
		public int TotalITBIS2 { get; set; }
		public int TotalITBIS3 { get; set; }
		public int MontoImpuestoAdicional { get; set; }
		public ImpuestosAdicionales ImpuestosAdicionales { get; set; }
		public int MontoTotal { get; set; }
		public int MontoNoFacturable { get; set; }
		public int MontoPeriodo { get; set; }
		public int SaldoAnterior { get; set; }
		public int MontoAvancePago { get; set; }
		public int ValorPagar { get; set; }
		public int TotalITBISRetenido { get; set; }
		public int TotalISRRetencion { get; set; }
		public int TotalITBISPercepcion { get; set; }
		public int TotalISRPercepcion { get; set; }
	}

	public class ImpuestoAdicionalOtraMoneda
	{
		public int TipoImpuestoOtraMoneda { get; set; }
		public int TasaImpuestoAdicionalOtraMoneda { get; set; }
		public int MontoImpuestoSelectivoConsumoEspecificoOtraMoneda { get; set; }
		public int MontoImpuestoSelectivoConsumoAdvaloremOtraMoneda { get; set; }
		public int OtrosImpuestosAdicionalesOtraMoneda { get; set; }
	}

	public class ImpuestosAdicionalesOtraMoneda
	{
		public List<ImpuestoAdicionalOtraMoneda> ImpuestoAdicionalOtraMoneda { get; set; }
	}

	public class OtraMoneda
	{
		public string TipoMoneda { get; set; }
		public int TipoCambio { get; set; }
		public int MontoGravadoTotalOtraMoneda { get; set; }
		public int MontoGravado1OtraMoneda { get; set; }
		public int MontoGravado2OtraMoneda { get; set; }
		public int MontoGravado3OtraMoneda { get; set; }
		public int MontoExentoOtraMoneda { get; set; }
		public int TotalITBISOtraMoneda { get; set; }
		public int TotalITBIS1OtraMoneda { get; set; }
		public int TotalITBIS2OtraMoneda { get; set; }
		public int TotalITBIS3OtraMoneda { get; set; }
		public int MontoImpuestoAdicionalOtraMoneda { get; set; }
		public ImpuestosAdicionalesOtraMoneda ImpuestosAdicionalesOtraMoneda { get; set; }
		public int MontoTotalOtraMoneda { get; set; }
	}

	public class Encabezado
	{
		public double Version { get; set; }
		public IdDoc IdDoc { get; set; }
		public Emisor Emisor { get; set; }
		public Comprador Comprador { get; set; }
		public InformacionesAdicionales InformacionesAdicionales { get; set; }
		public Transporte Transporte { get; set; }
		public Totales Totales { get; set; }
		public OtraMoneda OtraMoneda { get; set; }
	}

	public class CodigosItem
	{
		public string TipoCodigo { get; set; }
		public string CodigoItem { get; set; }
	}

	public class TablaCodigosItem
	{
		public List<CodigosItem> CodigosItem { get; set; }
	}

	public class Retencion
	{
		public int IndicadorAgenteRetencionoPercepcion { get; set; }
		public int MontoITBISRetenido { get; set; }
		public int MontoISRRetenido { get; set; }
	}

	public class SubcantidadItem
	{
		public int Subcantidad { get; set; }
		public int CodigoSubcantidad { get; set; }
	}

	public class TablaSubcantidad
	{
		public List<SubcantidadItem> SubcantidadItem { get; set; }
	}

	public class SubDescuento
	{
		public string TipoSubDescuento { get; set; }
		public int SubDescuentoPorcentaje { get; set; }
		public int MontoSubDescuento { get; set; }
	}

	public class TablaSubDescuento
	{
		public List<SubDescuento> SubDescuento { get; set; }
	}

	public class SubRecargo
	{
		public string TipoSubRecargo { get; set; }
		public int SubRecargoPorcentaje { get; set; }
		public int MontoSubRecargo { get; set; }
	}

	public class TablaSubRecargo
	{
		public List<SubRecargo> SubRecargo { get; set; }
	}

	public class TablaImpuestoAdicional
	{
		public List<ImpuestoAdicional> ImpuestoAdicional { get; set; }
	}

	public class OtraMonedaDetalle
	{
		public int PrecioOtraMoneda { get; set; }
		public int DescuentoOtraMoneda { get; set; }
		public int RecargoOtraMoneda { get; set; }
		public int MontoItemOtraMoneda { get; set; }
	}

	public class Item
	{
		public int NumeroLinea { get; set; }
		public TablaCodigosItem TablaCodigosItem { get; set; }
		public int IndicadorFacturacion { get; set; }
		public Retencion Retencion { get; set; }
		public string NombreItem { get; set; }
		public int IndicadorBienoServicio { get; set; }
		public string DescripcionItem { get; set; }
		public int CantidadItem { get; set; }
		public int UnidadMedida { get; set; }
		public int CantidadReferencia { get; set; }
		public int UnidadReferencia { get; set; }
		public TablaSubcantidad TablaSubcantidad { get; set; }
		public int GradosAlcohol { get; set; }
		public int PrecioUnitarioReferencia { get; set; }
		public string FechaElaboracion { get; set; }
		public string FechaVencimientoItem { get; set; }
		public int PrecioUnitarioItem { get; set; }
		public int DescuentoMonto { get; set; }
		public TablaSubDescuento TablaSubDescuento { get; set; }
		public int RecargoMonto { get; set; }
		public TablaSubRecargo TablaSubRecargo { get; set; }
		public List<TablaImpuestoAdicional> TablaImpuestoAdicional { get; set; }
		public OtraMonedaDetalle OtraMonedaDetalle { get; set; }
		public int MontoItem { get; set; }
	}

	public class DetallesItems
	{
		public List<Item> Item { get; set; }
	}

	public class Subtotal
	{
		public int NumeroSubTotal { get; set; }
		public string DescripcionSubtotal { get; set; }
		public int Orden { get; set; }
		public int SubTotalMontoGravadoTotal { get; set; }
		public int SubTotalMontoGravadoI1 { get; set; }
		public int SubTotalMontoGravadoI2 { get; set; }
		public int SubTotalMontoGravadoI3 { get; set; }
		public int SubTotaITBIS { get; set; }
		public int SubTotaITBIS1 { get; set; }
		public int SubTotaITBIS2 { get; set; }
		public int SubTotaITBIS3 { get; set; }
		public int SubTotalImpuestoAdicional { get; set; }
		public int SubTotalExento { get; set; }
		public int MontoSubTotal { get; set; }
		public int Lineas { get; set; }
	}

	public class Subtotales
	{
		public List<Subtotal> Subtotal { get; set; }
	}

	public class DescuentoORecargo
	{
		public int NumeroLinea { get; set; }
		public string TipoAjuste { get; set; }
		public int IndicadorNorma1007 { get; set; }
		public string DescripcionDescuentooRecargo { get; set; }
		public string TipoValor { get; set; }
		public int ValorDescuentooRecargo { get; set; }
		public int MontoDescuentooRecargo { get; set; }
		public int MontoDescuentooRecargoOtraMoneda { get; set; }
		public int IndicadorFacturacionDescuentooRecargo { get; set; }
	}

	public class DescuentosORecargos
	{
		public List<DescuentoORecargo> DescuentoORecargo { get; set; }
	}

	public class SubtotalImpuestoAdicional
	{
		public int SubtotalImpuestoSelectivoConsumoEspecificoPagina { get; set; }
		public int SubtotalOtrosImpuesto { get; set; }
	}

	public class Pagina
	{
		public int PaginaNo { get; set; }
		public int NoLineaDesde { get; set; }
		public int NoLineaHasta { get; set; }
		public int SubtotalMontoGravadoPagina { get; set; }
		public int SubtotalMontoGravado1Pagina { get; set; }
		public int SubtotalMontoGravado2Pagina { get; set; }
		public int SubtotalMontoGravado3Pagina { get; set; }
		public int SubtotalExentoPagina { get; set; }
		public int SubtotalItbisPagina { get; set; }
		public int SubtotalItbis1Pagina { get; set; }
		public int SubtotalItbis2Pagina { get; set; }
		public int SubtotalItbis3Pagina { get; set; }
		public int SubtotalImpuestoAdicionalPagina { get; set; }
		public SubtotalImpuestoAdicional SubtotalImpuestoAdicional { get; set; }
		public int MontoSubtotalPagina { get; set; }
		public int SubtotalMontoNoFacturablePagina { get; set; }
	}

	public class Paginacion
	{
		public List<Pagina> Pagina { get; set; }
	}

	public class InformacionReferencia
	{
		public string NCFModificado { get; set; }
		public string RNCOtroContribuyente { get; set; }
		public string FechaNCFModificado { get; set; }
		public int CodigoModificacion { get; set; }
	}

	public class ECF
	{
		public Encabezado Encabezado { get; set; }
		public DetallesItems DetallesItems { get; set; }
		public Subtotales Subtotales { get; set; }
		public DescuentosORecargos DescuentosORecargos { get; set; }
		public Paginacion Paginacion { get; set; }
		public InformacionReferencia InformacionReferencia { get; set; }
		public string FechaHoraFirma { get; set; }
		public string AnyElement { get; set; }
	}


}
