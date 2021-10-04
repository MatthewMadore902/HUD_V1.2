using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUD_V1._2
{
	class Program
	{
		static int Health = 100;
		static int Pistol = 0;
		static int ShotGun = 1;
		static int Spreader = 2;
		static int Laser = 3;
		static int Sniper = 4;
		static int BFG = 4;
		static int Lives = 3;
		static int damage;

		static void Main(string[] args)
		{

		}

		void health()
		{
			if (Health > 100)
			{
				Console.WriteLine("You are healthy");
			}
			if (Health < 75)
			{
				Console.WriteLine("Nothing but a scratch");
			}

			if (Health < 50)
			{
				Console.WriteLine("Hurt");
			}
			if (Health < 25)
			{
				Console.WriteLine("OOOO The Pain!!");
			}
			if (Health < 10)
			{
				Console.WriteLine("Heal you madman");
			}
			if (Health < 0)
			{
				Lives = Lives - 1;
				Console.WriteLine("You have died");
			}
		}


		void TakeDamage()
		{
			System.Random random = new System.Random();
			damage = random.Next(1, 25);

		}

		void Heal()
		{
			if (Health < 100)
			{
				Console.WriteLine("Would you like some health");
			}
			//if (
		}

		static void ChangeWeapon()
		{
			if(

		}
		void ShowHUD()
		{

			Console.WriteLine("Health - " + Health);
			//Console.WriteLine("Current weapon - " + Weapon);
			Console.WriteLine("Lives - " + Lives);

		}
	}
}
