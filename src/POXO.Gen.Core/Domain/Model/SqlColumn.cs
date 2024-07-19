using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POXO.Gen.Core.Domain.Model
{
    public class SqlColumn
    {
        public string ColumnName { get; set; } = null!;
        public string BaseColumnName { get; set; } = null!;
        public string BaseTableName { get; set; } = null!;
        public string DataType { get; set; } = null!;
        public string ProviderSpecificDataType { get; set; } = null!;
        public string DataTypeName { get; set; } = null!;

        public int ColumnOrdinal { get; set; }
        public int ColumnSize { get; set; }
        public int NumericPrecision { get; set; }
        public int NumericScale { get; set; }

        public int ProviderType { get; set; }
        public int NonVersionedProviderType { get; set; }

        public bool IsUnique { get; set; }
        public bool IsColumnSet { get; set; }
        public bool AllowDBNull { get; set; }
        public bool IsKey { get; set; }
        public bool IsIdentity { get; set; }
        public bool IsAutoIncrement { get; set; }
        public bool IsRowVersion { get; set; }
        public bool IsLong { get; set; }
        public bool IsReadOnly { get; set; }

    }
}
