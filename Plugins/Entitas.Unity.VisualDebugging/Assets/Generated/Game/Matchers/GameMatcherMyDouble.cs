//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public sealed partial class GameMatcher {

    static IMatcher<GameEntity> _matcherMyDouble;

    public static IMatcher<GameEntity> MyDouble {
        get {
            if(_matcherMyDouble == null) {
                var matcher = (Matcher<GameEntity>)Matcher<GameEntity>.AllOf(GameComponentsLookup.MyDouble);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMyDouble = matcher;
            }

            return _matcherMyDouble;
        }
    }
}
