using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FunctionsAndParameters : MonoBehaviour {
    public int Health = 20;
    void OnTriggerEnter (Collider other)
	{
		print("Hit someithing");
		print("other");
		print("penalty");

		AddNumbers(14, 2);
		PlayerData("bob");
		AddHealth(25);
		MapOfCity("hEREBOR");
		AmountOfMoney(50, 8);
		CarRaces("Ferrari");
	}
	void AddNumbers (int a, int b) 
	{
		print(a += b);
	}
	void PlayerData(string name)
	{
		print("this player is" + name);
	}
	void AddHealth(int newHealth)
	{
		Health += newHealth;
	}
	void MyPlayer(bool trigger)
	{
		if (true)
		{
			print("true");
		}
	}
	void MapOfCity(string City)
	{
		print("Open map of" + City + "City" );
	}
	void AmountOfMoney(int cash, int currentmoney)
	{
			print(cash += currentmoney);
	}
	void NinjaClass(bool Ninja)
	{
		if(true)
		{
			print("you are now a super ninja");
		}
	}
	void CarRaces (string car)
	{
		print("50" + car + "are competing in the race");
	}
	void Penalty (bool pause)
	{
		if (true)
		print("pause the game");
	}
	void OnMouseDown()
	{
		print("swaggy ninga");
	}
}
//the first is the call and then it is fallowed by the declaration.
//this format gives you the ability to do what we've been doing with public bools.
//the simpler code is public int Powerlevel;
//the longer code which is written here is to save us time down the road. because this way you will do 100 powerleves instead of a 1000 with the first one
//longer code can be better.