using Code.Gameplay.Features.Enemy;
using Code.Gameplay.Features.Enemy.Factory;
using Code.Gameplay.Features.Hero.Factory;
using Code.Gameplay.Levels;
using Code.Infrastructure.States.StateInfrastructure;
using Code.Infrastructure.States.StateMachine;
using UnityEngine;

namespace Code.Infrastructure.States.GameStates
{
	public class BattleEnterState : IState
	{
		private readonly IGameStateMachine _stateMachine;
		private readonly ILevelDataProvider _levelDataProvider;
		private readonly IHeroFactory _heroFactory;
		private readonly IEnemyFactory _enemyFactory;

		public BattleEnterState(
			IGameStateMachine stateMachine,
			ILevelDataProvider levelDataProvider,
			IHeroFactory heroFactory,
			IEnemyFactory enemyFactory)
		{
			_stateMachine = stateMachine;
			_levelDataProvider = levelDataProvider;
			_heroFactory = heroFactory;
			_enemyFactory = enemyFactory;
		}

		public void Enter()
		{
			PlaceHero();
			_enemyFactory.CreateEnemy(_levelDataProvider.StartPoint + Vector3.one, EnemyTypeId.Orc);


			_stateMachine.Enter<BattleLoopState>();
		}

		private void PlaceHero() => 
			_heroFactory.CreateHero(_levelDataProvider.StartPoint);

		public void Exit()
		{

		}
	}
}