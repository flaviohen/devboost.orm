using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DevBoost.ORM.App
{
	class Program
	{
		static void Main(string[] args)
		{
			DevboostContext contextCBF = new DevboostContext();


			TbClube clube = new TbClube();
			clube.Clube = "Flamengo";
			contextCBF.TbClube.Add(clube);
			contextCBF.SaveChanges();

			TbJogador jogador2 = new TbJogador();
			jogador2.Nome = "Jogador TESTE2";
			jogador2.DataNascimento = DateTime.Now;
			jogador2.IdClube = clube.IdClube;
			contextCBF.TbJogador.Add(jogador2);
			contextCBF.SaveChanges();

			TbPosicao posicao = new TbPosicao();
			posicao.Posicao = "Lateral";
			posicao.IdJogador = jogador2.IdJogador;
			contextCBF.TbPosicao.Add(posicao);
			contextCBF.SaveChanges();

			var jogadores = contextCBF.TbJogador.ToList();
			var posicoes = contextCBF.TbPosicao.ToList();
			var clubes = contextCBF.TbClube.ToList();

			Console.WriteLine("Jogadores");
			int i = 0;
			foreach (var item in jogadores)
			{
				i++;
				Console.WriteLine(string.Format("{0} - {1} - {2}",i, item.Nome, item.DataNascimento));
			}

			Console.WriteLine("Posições");
			i = 0;
			foreach (var item in posicoes)
			{
				i++;
				Console.WriteLine(string.Format("{0} - {1}", i, item.Posicao));
			}
			i = 0;
			foreach (var item in clubes)
			{
				i++;
				Console.WriteLine(string.Format("{0} - {1}", i, item.Clube));
				foreach (var jogador in item.TbJogador)
				{
					Console.WriteLine(string.Format("{0} - {1}\n", jogador.Nome,jogador.TbPosicao.ToList()[0].Posicao));
				}
			}

			




			Console.ReadKey();
		}
	}
}
