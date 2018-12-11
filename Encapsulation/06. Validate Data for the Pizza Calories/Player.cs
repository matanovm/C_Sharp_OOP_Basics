﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Football_Team_Generator
{
	class Player
	{
		private const int MinStatsValue = 0;
		private const int MaxStatsValue = 100;
		private string _name;
		private double _endurance;
		private double _sprint;
		private double _dribble;
		private double _passing;
		private double _shooting;
		private double _skillLevel;

		public Player(string name, double endurance, double sprint, double dribble, double passing, double shooting)
		{
			_name = name;
			_endurance = endurance;
			_sprint = sprint;
			_dribble = dribble;
			_passing = passing;
			_shooting = shooting;
			_skillLevel = (endurance + sprint + dribble + passing + shooting) / 5;
		}

		public string Name
		{
			get { return _name; }

			private set
			{
				bool valueNull = string.IsNullOrWhiteSpace(value);
				bool valueEmpty = value == string.Empty;

				if (valueNull || valueEmpty)
				{
					throw new ArgumentException("A name should not be empty.");
				}

				_name = value;
			}
		}

		public double SkillLevel { get { return _skillLevel; } }

		private double Shooting
		{
			set
			{
				ValidateStat(value, nameof(Shooting));
				_shooting = value;
			}
		}

		private double Passing
		{
			set
			{
				ValidateStat(value, nameof(Passing));
				_passing = value;
			}
		}

		private double Dribble
		{
			set
			{
				this.ValidateStat(value, nameof(this.Dribble));
				_dribble = value;
			}
		}

		private double Sprint
		{
			set
			{
				this.ValidateStat(value, nameof(this.Sprint));
				_sprint = value;
			}
		}

		private double Endurance
		{
			set
			{
				this.ValidateStat(value, nameof(this.Endurance));
				_endurance = value;
			}
		}

		private void ValidateStat(double stat, string propertyName)
		{
			bool statValueMin = stat < MinStatsValue;
			bool statValueMax = stat > MaxStatsValue;

			if (statValueMin || statValueMax)
			{
				throw new ArgumentException($"{propertyName} should be between 0 and 100.");
			}
		}
	}
}
