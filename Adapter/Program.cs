using Adapter;

IPago pago = new PagoTransferencia();
Ventas venta = new Ventas(pago);
venta.ProcesarPago();

IPago pago1 = new PagoEfectivo();
Ventas venta1 = new Ventas(pago1);
venta1.ProcesarPago();

IPago pagoTC = new PagoTarjetaCredito("0123");
Ventas ventaTC = new Ventas(pagoTC);
ventaTC.ProcesarPago();


IPago pagoRP = new PagoRiotPoint();
Ventas ventaRP = new Ventas(pagoRP);
ventaRP.ProcesarPago();

IPago pagoEA = new PagoEsenciaAzul();
Ventas ventaEA = new Ventas(pagoEA);
ventaEA.ProcesarPago();

IPago pagoBen = new PagoBendicion();
Ventas ventaBen = new Ventas(pagoBen);
ventaBen.ProcesarPago();

IPago pagoClap = new PagoAplauso();
Ventas ventaClap = new Ventas(pagoClap);
ventaClap.ProcesarPago();

IPago pagoR = new PagoRobux();
Ventas ventaR = new Ventas(pagoR);
ventaR.ProcesarPago();
