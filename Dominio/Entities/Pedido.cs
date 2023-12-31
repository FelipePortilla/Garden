﻿using System;
using System.Collections.Generic;
using Dominio.Entities;
namespace Persistencia;

public partial class Pedido : BaseEntity
{
    public int CodigoPedido { get; set; }

    public DateOnly FechaPedido { get; set; }

    public DateOnly FechaEsperada { get; set; }

    public DateOnly? FechaEntrega { get; set; }

    public string Estado { get; set; }

    public string Comentarios { get; set; }

    public int CodigoCliente { get; set; }

    public virtual Cliente CodigoClienteNavigation { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();
}
