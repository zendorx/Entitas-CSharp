//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public StandardComponent standard { get { return (StandardComponent)GetComponent(TestComponentsLookup.Standard); } }
    public bool hasStandard { get { return HasComponent(TestComponentsLookup.Standard); } }

    public void AddStandard(string newValue) {
        var component = CreateComponent<StandardComponent>(TestComponentsLookup.Standard);
        component.value = newValue;
        AddComponent(TestComponentsLookup.Standard, component);
    }

    public void ReplaceStandard(string newValue) {
        var component = CreateComponent<StandardComponent>(TestComponentsLookup.Standard);
        component.value = newValue;
        ReplaceComponent(TestComponentsLookup.Standard, component);
    }

    public void RemoveStandard() {
        RemoveComponent(TestComponentsLookup.Standard);
    }
}
