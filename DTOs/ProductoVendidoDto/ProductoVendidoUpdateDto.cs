﻿namespace WebApi_Proyecto_Final.DTOs.ProductoVendidoDto
{
    public class ProductoVendidoUpdateDto
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }
    }
}
