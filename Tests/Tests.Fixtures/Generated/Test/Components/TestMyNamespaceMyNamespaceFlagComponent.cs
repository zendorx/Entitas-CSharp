//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    static readonly My.Namespace.MyNamespaceFlagComponent myNamespaceMyNamespaceFlagComponent = new My.Namespace.MyNamespaceFlagComponent();

    public bool isMyNamespaceMyNamespaceFlag {
        get { return HasComponent(TestComponentsLookup.MyNamespaceMyNamespaceFlag); }
        set {
            if(value != isMyNamespaceMyNamespaceFlag) {
                if(value) {
                    AddComponent(TestComponentsLookup.MyNamespaceMyNamespaceFlag, myNamespaceMyNamespaceFlagComponent);
                } else {
                    RemoveComponent(TestComponentsLookup.MyNamespaceMyNamespaceFlag);
                }
            }
        }
    }
}
