using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Project
{
	class ObradaPodataka
	{
		string _upisanoVrijeme;
		string _message;
		System.Timers.Timer timer;
		public ObradaPodataka ()
		{
		}

		public string odrediDanEngl(string upisaniDan, out string upisaniDanEng)
        {
			switch (upisaniDan.ToLower())
			{
				case "ponedjeljak":
					upisaniDanEng = "Monday";
					break;
				case "utorak":
					upisaniDanEng = "Tuesday";
					break;
				case "srijeda":
					upisaniDanEng = "Wednesday";
					break;
				case "cetvrtak":
					upisaniDanEng = "Thursday";
					break;
				case "petak":
					upisaniDanEng = "Friday";
					break;
				case "subota":
					upisaniDanEng = "Saturday";
					break;
				case "nedjelja":
					upisaniDanEng = "Sunday";
					break;
				case "svi":
					upisaniDanEng = "svi";
					break;
				default:
					upisaniDanEng = "pogreska";
					break;
			}
			return upisaniDanEng;
			}
		}
	
	}
	

