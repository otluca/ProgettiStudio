using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiVari
{
    class Comparable
    {
        public string AString { get; set; }
        public long ALong { get; set; }
        public double ADouble { get; set; }
        public DateTime ADateTime { get; set; }


        public static Dictionary<string, string> GetChanges<T>(T original, T current)
            where T : class
        {
            var originalType = original.GetType();
            var propertyList = originalType.GetProperties();

            Dictionary<string, string> result = new Dictionary<string, string>();

            foreach (var property in propertyList) {
                Type t = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;

                var originalValue = property.GetValue(original);
                var currentValue = property.GetValue(current);
                if (originalValue == null && currentValue != null ||
                    originalValue != null && currentValue == null) { 
                    result[property.Name] = currentValue == null ?
                        "NULL" : Convert.ChangeType(currentValue, t).ToString();
                }
                else if (originalValue != null && currentValue != null) {
                    dynamic originalConvertedValue = Convert.ChangeType(originalValue, t);
                    dynamic currentConvertedValue = Convert.ChangeType(currentValue, t);

                    if (originalConvertedValue != currentConvertedValue) {
                        if (t.Name == "DateTime") {
                            result[property.Name] = currentConvertedValue.ToString("o");
                        }
                        else {
                            result[property.Name] = currentConvertedValue.ToString();
                        }
                    }
                }
            }

            return result;
        }
    }
}
