﻿using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Infrastructure.Identifiers;
using UnityEngine;

namespace Code.Gameplay.Features.Hero.Factory
{
	public class HeroFactory : IHeroFactory
	{
		private const string HeroViewPath = "Hero";

		private readonly IIdentifierService _identifier;


		public HeroFactory(IIdentifierService identifier) => 
			_identifier = identifier;

		public GameEntity CreateHero(Vector3 at)
		{
			  return CreateEntity.Empty()
				.AddId(_identifier.Next())
				.AddWorldPosition(at)
				.AddDirection(Vector2.zero)
				.AddCurrentHp(100)
				.AddMaxHp(100)
				.AddSpeed(2)
				.AddViewPath(HeroViewPath)
				.With(x => x.isHero = true)
				.With(x => x.isMovementAvailable = true)
				;
		}
	}
}