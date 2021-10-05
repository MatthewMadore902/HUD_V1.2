using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUD_V1._2
{
	class program
	{
		static int Health = 100;
		static string Pistol = "Pistol";
		static string ShotGun = "ShotGun";
		static string Rocket = "Rocket Luncher";
		static string Laser = "Laser";
		static string Sniper = "Sniper";
		static string BFG = "BFG";
		static int Lives = 3;
		static int damage;
		static string currentWeapon;
		static int damageDelt;
		static System.Random random = new System.Random();

		static void DealDamage()
		{

			damageDelt = random.Next(1, 50);
		}

		static void TakeDamage()
		{
			//System.Random random = new System.Random();
			damage = random.Next(1, 25);
			//Health = Health - damage;
		}



		static void GamePlay()
		{	
			Console.WriteLine("A Demon Runs At Your Out Of No where");
			Console.WriteLine("You Delt " + damageDelt + " damage");
			Console.WriteLine("The Demon Hits You for " + damage + " Damage");
			Health = Health - damage;
			Console.ReadKey();
		}
		static void health()
		{
			Health = 100;

			if (Health < 100)
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
				Console.WriteLine("You have lost a live");
				Health = Health + 100;
				Health = 0;
			}
		}


		static void Heal()
		{
			if (Health < 20)
			{
				Console.WriteLine("Would you like some health   Y/N");
			}

			string user = Console.ReadLine();

			if (user == "Y")
			{
				Health = Health + 25;
			}
			if (user == "N")
			{
				Health = Health + 0;
			}
		}

		static void ChangeWeapon()
		{
			//System.Random random = new System.Random();
			//currentWeapon = Convert.ToString(random.Next(1, 6));
			Console.WriteLine("You Find  Weapon Box What Will You Pick?, Pick a number from 1 to 6 : ");
			string Weapon = Console.ReadLine();

			if (Weapon == "1")
			{
				currentWeapon = Pistol;
			}
			if (Weapon == "2")
			{
				currentWeapon = ShotGun;
			}
			if (Weapon == "3")
			{
				currentWeapon = Rocket;
			}
			if (Weapon == "4")
			{
				currentWeapon = Laser;
			}
			if (Weapon == "5")
			{
				currentWeapon = Sniper;
			}
			if (Weapon == "6")
			{
				currentWeapon = BFG;
			}
			//Console.ReadKey();
		}



		static void ShowHUD()
		{
			Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
			Console.WriteLine("Health - " + Health);
			Console.WriteLine("Current weapon - " + currentWeapon);
			Console.WriteLine("Lives - " + Lives);
			Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
			Console.ReadKey();
		}

		static void Main(string[] args)
		{
;			health();
			DealDamage();
			TakeDamage();
			ShowHUD();
			ChangeWeapon();
			Heal();
			ShowHUD();
			GamePlay();
			DealDamage();
			TakeDamage();
			ShowHUD();
			ChangeWeapon();
			ShowHUD();
			GamePlay();
			DealDamage();
			TakeDamage();
			ShowHUD();
			ChangeWeapon();
			ShowHUD();
			GamePlay();
			DealDamage();
			TakeDamage();
			ShowHUD();
			ChangeWeapon();
			ShowHUD();
			GamePlay();
			DealDamage();
			TakeDamage();
			ShowHUD();
			ChangeWeapon();
			ShowHUD();
			GamePlay();
			DealDamage();
			TakeDamage();
			ShowHUD();
			ChangeWeapon();
			ShowHUD();
			GamePlay();
			DealDamage();
			TakeDamage();
			ShowHUD();
			ChangeWeapon();
			ShowHUD();
			GamePlay();
			DealDamage();
			TakeDamage();
			ShowHUD();
			ChangeWeapon();
			ShowHUD();
			GamePlay();
			DealDamage();
			TakeDamage();
			ShowHUD();
			ChangeWeapon();
			ShowHUD();
			GamePlay();
			DealDamage();
			TakeDamage();
			ShowHUD();
			ChangeWeapon();
			ShowHUD();
			GamePlay();
			DealDamage();
			TakeDamage();
			ShowHUD();
			ChangeWeapon();
			ShowHUD();
			GamePlay();
			DealDamage();
			TakeDamage();
			ShowHUD();
			ChangeWeapon();
			ShowHUD();
			GamePlay();




		}


	}
}
