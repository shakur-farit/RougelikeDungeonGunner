//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherEnemyAnimator;

    public static Entitas.IMatcher<GameEntity> EnemyAnimator {
        get {
            if (_matcherEnemyAnimator == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EnemyAnimator);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEnemyAnimator = matcher;
            }

            return _matcherEnemyAnimator;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.Gameplay.Features.Enemy.EnemyAnimatorComponent enemyAnimator { get { return (Code.Gameplay.Features.Enemy.EnemyAnimatorComponent)GetComponent(GameComponentsLookup.EnemyAnimator); } }
    public Code.Gameplay.Features.Enemy.Behaviours.EnemyAnimator EnemyAnimator { get { return enemyAnimator.Value; } }
    public bool hasEnemyAnimator { get { return HasComponent(GameComponentsLookup.EnemyAnimator); } }

    public GameEntity AddEnemyAnimator(Code.Gameplay.Features.Enemy.Behaviours.EnemyAnimator newValue) {
        var index = GameComponentsLookup.EnemyAnimator;
        var component = (Code.Gameplay.Features.Enemy.EnemyAnimatorComponent)CreateComponent(index, typeof(Code.Gameplay.Features.Enemy.EnemyAnimatorComponent));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceEnemyAnimator(Code.Gameplay.Features.Enemy.Behaviours.EnemyAnimator newValue) {
        var index = GameComponentsLookup.EnemyAnimator;
        var component = (Code.Gameplay.Features.Enemy.EnemyAnimatorComponent)CreateComponent(index, typeof(Code.Gameplay.Features.Enemy.EnemyAnimatorComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveEnemyAnimator() {
        RemoveComponent(GameComponentsLookup.EnemyAnimator);
        return this;
    }
}
