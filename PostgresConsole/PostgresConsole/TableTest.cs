using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostgresConsole
{

    [Table(name: "tabletests")]
    public class TableTest
    {
        [Column(name: "idtabletest")]
        public long IdTableTest { get; set; }

        [Column(name: "testclass")]
        public int? TestClass { get; set; }

        [Column(name: "testdescription")]
        public string TestDescription { get; set; }

        [Column(name: "testdata")]
        public string TestData { get; set; }


        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}
