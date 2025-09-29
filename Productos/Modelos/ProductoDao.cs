using Productos.Modelos;
using Productos.Dao;
using System;

namespace Productos.Dao
{
    public class ProductoDao
    {
        private static int TAM = 5;
        private ProductoDao[] carrito = new Producto[10];
        private int pos = 0;

        public void Agregar(Producto prod)
        {
            if (pos < TAMAÑO)

            {
                carrito[pos++] = prod;
            }
        }
        public Producto[] VerCarrito()
        {
            return carrito;
        }

        public void AplicarIva(ref Producto prod)
        {
            if (prod.IVA)
        }
    }
}
