using PuntoDeVentaSOLID;
using System;

//Adapter
IPagoPVS pagoPVS = new PagoMonedaAdapter();
VentasAdapter ventasAdapter = new VentasAdapter(pagoPVS);
ventasAdapter.Cobrar();

//Strategy
ProductoPVS producto = new ProductoPVS(new DescuentoMonedaStrategy());
producto.Nombre = "Apple Watch";
producto.Precio = 10000m;

Console.WriteLine($"El descuento que se aplico es del: {producto.Descuento / producto.Precio}%");
//Decorator