﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Arbol
{
    class Nodo
    {
        public int Id { get; set; }
        public string Valor { get; set; }
        public List<Nodo> Hijos { get; set; } = new List<Nodo>();

    }
}