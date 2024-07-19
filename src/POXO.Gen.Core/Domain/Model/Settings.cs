using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POXO.Gen.Core.Domain.Model
{
    public class Settings
    {
        public List<string> SqlConnectionStrings { get; set; } = null!;
        public List<string> MySqlConnectionStrings { get; set; } = null!;
        public string? SelectedConnection { get; set; }
    }
}
