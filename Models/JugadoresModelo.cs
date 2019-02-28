﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo_del.Models
{
    public class JugadoresModelo
    {
        // GET: JugadoresModels
        ContextoJugadores contexto;
        public JugadoresModelo()
        {
            contexto = new ContextoJugadores();
        }
        public List<GOLEADORES> GetGoleadores()
        {
            var consulta = from datos in contexto.GOLEADORES select datos;
            return consulta.ToList();

        }
    }
}