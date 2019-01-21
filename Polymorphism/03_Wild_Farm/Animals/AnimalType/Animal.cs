﻿using _03.Wild_Farm.Food;
using System;
using System.Linq;

namespace _03.Wild_Farm.Animals.Animal_Type
{
	public abstract class Animal
	{
		public Animal(string name, double weight)
		{
			Name = name;
			Weight = weight;
			FoodEaten = 0;
		}

		public string Name
		{
			get;
			set;
		}

		public double Weight
		{
			get;
			set;
		}

		public int FoodEaten
		{
			get;
			set;
		}

		protected virtual Type[] PreferredFoods => new Type[] { typeof(Vegetable), typeof(Meat), typeof(Fruit),
			typeof(Seeds) };

		protected virtual double WeightIncreaseMultiplier => 1;

		public void TryEatFood(Foods food)
		{
			Type typeofFood = food.GetType();

			if (!PreferredFoods.Contains(food.GetType()))
			{
				throw new InvalidOperationException($"{GetType().Name} does not eat {typeofFood.Name}!");
			}

			FoodEaten += food.Quantity;
			Weight += food.Quantity * WeightIncreaseMultiplier;
		}

		public abstract string MakeSound();

		public override string ToString()
		{
			return $"{GetType().Name} [{Name}, " +
				"{0}" + $"{Weight}, " + "{1}" + $"{FoodEaten}]";
		}
	}
}
