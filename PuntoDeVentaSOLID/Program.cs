using PuntoDeVentaSOLID;

//Adapter
IPagoPVS pagoPVS = new PagoMonedaAdapter();
VentasAdapter ventasAdapter = new VentasAdapter(pagoPVS);
ventasAdapter.Cobrar();

//Strategy


//Decorator