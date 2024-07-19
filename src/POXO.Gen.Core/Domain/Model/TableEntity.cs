using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POXO.Gen.Core.Domain.Model
{
    public class TableEntity
    {
        public string EntityName { get; set; } = null!;
        public DataTable SchemaTable { get; set; } = null!;
        public DataTable DataTable { get; set; } = null!;
        public List<SqlColumn> SqlColumns { get; set; }
        public string Code { get; set; } = null!;
    }
}
