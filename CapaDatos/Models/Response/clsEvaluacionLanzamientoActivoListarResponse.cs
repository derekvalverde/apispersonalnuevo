﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Models.Response
{
   public class clsEvaluacionLanzamientoActivoListarResponse
    {
        public int evaId { get; set; }
        public string evlEstado { get; set; }
        public int evaLimiteIntentos { get; set; }
        public DateTime evlFechaInicio { get; set; }
        public DateTime evlFechaFin { get; set; }
        public int evlDuracion { get; set; }
    }
}