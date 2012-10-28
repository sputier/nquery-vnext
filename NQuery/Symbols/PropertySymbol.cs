using System;

namespace NQuery.Symbols
{
    public class PropertySymbol : Symbol
    {
        private readonly Type _type;

        public PropertySymbol(string name, Type type)
            : base(name)
        {
            _type = type;
        }

        public override SymbolKind Kind
        {
            get { return SymbolKind.Property; }
        }

        public override Type Type
        {
            get { return _type; }
        }
    }
}