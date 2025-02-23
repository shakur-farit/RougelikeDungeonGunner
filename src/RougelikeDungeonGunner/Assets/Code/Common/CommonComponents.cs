﻿using Code.Infrastructure.View;
using Entitas;

namespace Code.Common
{
	[Game] public class View : IComponent { public IEntityView Value; }
	[Game] public class Destructed : IComponent { }
	[Game] public class SelfDestructedTimer : IComponent { public float Value; }
	[Game] public class ViewPath : IComponent { public string Value; }
	[Game] public class ViewPrefab : IComponent { public EntityBehaviour Value; }
}