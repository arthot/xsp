﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mono.WebServer.Fpm {
	class ConfigurationManager : Options.ConfigurationManager
	{


		protected override string Name {
			get { return "mono-fpm"; }
		}

		protected override string Description
		{
			get { return "mono-fpm is a FastCgi process manager."; }
		}
	}
}
