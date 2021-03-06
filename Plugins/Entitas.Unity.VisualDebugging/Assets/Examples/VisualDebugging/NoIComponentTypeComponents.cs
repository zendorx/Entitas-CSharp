using System;
using Entitas.CodeGenerator;
using Entitas.CodeGenerator.Api;

[Game]
public class SomeClass {

    public string name;

    public SomeClass(string name) {
        this.name = name;
    }
}

[Game]
public struct SomeStruct {

    public string name;

    public SomeStruct(string name) {
        this.name = name;
    }
}

namespace SomeNamespace {

    [Game]
    public class SomeOtherClass {

        public string name;

        public SomeOtherClass(string name) {
            this.name = name;
        }
    }
}

[Game]
public class SomeGenericClass<T> {
    public T value;
}

[Game, Unique]
public class ISomeInterface {
}

[Game, CustomComponentName("CoolNameComponent")]
public class BadName {
}
    
[Serializable, Game, CustomComponentName("PositionComponent", "VelocityComponent")]
public struct IntVector2 {
    public int x;
    public int y;
}
