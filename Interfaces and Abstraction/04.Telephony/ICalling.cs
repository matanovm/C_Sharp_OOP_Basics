﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Telephony
{
	public interface ICalling : IPhone
	{
		string Browse(string url);
	}
}
