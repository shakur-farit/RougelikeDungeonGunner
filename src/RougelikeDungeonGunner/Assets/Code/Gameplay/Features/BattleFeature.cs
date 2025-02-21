﻿using Code.Gameplay.Features.Hero.Behaviours;
using Code.Gameplay.Features.Movement;
using Code.Gameplay.Input;
using Code.Infrastructure;

namespace Code.Gameplay.Features
{
	public sealed class BattleFeature : Feature
	{
		public BattleFeature(ISystemsFactory systems)
		{
			Add(systems.Create<InputFeature>());

			Add(systems.Create<HeroFeature>());
			Add(systems.Create<MovementFeature>());
		}
	}
}