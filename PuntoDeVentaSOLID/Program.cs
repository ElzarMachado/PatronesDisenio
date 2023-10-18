using PuntoDeVentaSOLID;

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

List<string> productos = new List<string>()
{
    "Apple Watch, ", "Iphone ", "Ipad"
};

CargoExtraDecorator cargoExtraDecorator = new CargoExtraDecorator(new VentaExtra(productos), producto.Precio + 69);
Console.WriteLine($"Si se agrega {string.Join("", productos)} el total sera de:{cargoExtraDecorator}");
Console.WriteLine($"Total {producto.Nombre}: {producto.Descuento}");
