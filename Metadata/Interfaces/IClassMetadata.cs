﻿using System.Collections.Generic;

namespace Typewriter.Metadata.Interfaces
{
    public interface IClassMetadata : INamedItem
    {
        bool IsGeneric { get; }
        string Namespace { get; }
        IEnumerable<IAttributeMetadata> Attributes { get; }
        IClassMetadata BaseClass { get; }
        IClassMetadata ContainingClass { get; }
        IEnumerable<IConstantMetadata> Constants { get; }
        IEnumerable<IFieldMetadata> Fields { get; }
        IEnumerable<IInterfaceMetadata> Interfaces { get; }
        IEnumerable<IMethodMetadata> Methods { get; }
        IEnumerable<IPropertyMetadata> Properties { get; }
        IEnumerable<ITypeMetadata> GenericTypeArguments { get; }
        IEnumerable<IClassMetadata> NestedClasses { get; }
        IEnumerable<IEnumMetadata> NestedEnums { get; }
        IEnumerable<IInterfaceMetadata> NestedInterfaces { get; }
    }
}