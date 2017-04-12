//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public MyDoubleComponent myDouble { get { return (MyDoubleComponent)GetComponent(GameComponentsLookup.MyDouble); } }
    public bool hasMyDouble { get { return HasComponent(GameComponentsLookup.MyDouble); } }

    public void AddMyDouble(double newMyDouble) {
        var index = GameComponentsLookup.MyDouble;
        var component = CreateComponent<MyDoubleComponent>(index);
        component.myDouble = newMyDouble;
        AddComponent(index, component);
    }

    public void ReplaceMyDouble(double newMyDouble) {
        var index = GameComponentsLookup.MyDouble;
        var component = CreateComponent<MyDoubleComponent>(index);
        component.myDouble = newMyDouble;
        ReplaceComponent(index, component);
    }

    public void RemoveMyDouble() {
        RemoveComponent(GameComponentsLookup.MyDouble);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherMyDouble;

    public static Entitas.IMatcher<GameEntity> MyDouble {
        get {
            if(_matcherMyDouble == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MyDouble);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMyDouble = matcher;
            }

            return _matcherMyDouble;
        }
    }
}
