using System.Collections.Generic;
using System.Collections.ObjectModel;
using NQuery.Language.Binding;

namespace NQuery.Language.Symbols
{
    public abstract class TableSymbol : Symbol
    {
        private readonly ReadOnlyCollection<ColumnSymbol> _columns;

        protected TableSymbol(string name, IList<ColumnSymbol> columns)
            : base(name)
        {
            _columns = new ReadOnlyCollection<ColumnSymbol>(columns);
        }

        public ReadOnlyCollection<ColumnSymbol> Columns
        {
            get { return _columns; }
        }

        public override string ToString()
        {
            return Type.IsMissing()
                       ? string.Format("TABLE {0}", Name)
                       : string.Format("TABLE {0}: {1}", Name, Type.ToDisplayName());
        }
    }
}