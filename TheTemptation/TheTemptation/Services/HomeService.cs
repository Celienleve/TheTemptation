using Microsoft.EntityFrameworkCore;
using TheTemptation.Controllers;
using TheTemptation.Models;

using DataLayer;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheTemptation.Services;

namespace TheTemptation.Services
{
	public class HomeService : IHomeService
	{
        private readonly TheTemptationDBContext dBContext;

        public HomeService(TheTemptationDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public string AffichageJeu()
		{
			var table = dBContext.Draws.Where(j => j.GameWin == "19,93,93,02").FirstOrDefault();

			var resultat = new IndexViewModel
			{
				GameWin = table.GameWin
			};

			return resultat.GameWin;
		}
	}
}
