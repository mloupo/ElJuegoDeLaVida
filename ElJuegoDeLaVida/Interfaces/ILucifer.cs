﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJDLV.Entidades.Interfaces
{
	public interface ILucifer : IEntidadEspecial
	{
		void Tentar(IEntidad entidad);

		void Maldicion(IEntidad entidad);
	}
}
