using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard.Enums
{
    public class Utils<T>
    {
        public static string GetDescription(T enumValue, string defaultDescription)
        {
            string result = String.Empty;

            string[] enumStrings = enumValue.ToString().Split(',');

            foreach (var val in enumStrings)
            {
                FieldInfo fi = enumValue.GetType().GetField(val.Trim());

                if (null != fi)
                {
                    object[] attrs = fi.GetCustomAttributes (typeof(DescriptionAttribute), true);

                    if (attrs.Length > 0) result += ((DescriptionAttribute)attrs[0]).Description + " ";
                }
            }

            result = string.IsNullOrEmpty(result) ? defaultDescription : result;

            return result.Trim();
        }

        public static string GetDescription(T enumValue)
        {
            return GetDescription(enumValue, string.Empty);
        }

        public static List<string> GetDescriptions()
        {
            List<string> results = new List<string>();
            var values = Enum.GetValues(typeof(T));
            foreach (var value in values)
            {
                results.Add(GetDescription((T)value));
            }

            return results;
        }

        public static T FromDescription(string description)
        {
            Type t = typeof(T);

            foreach (FieldInfo fi in t.GetFields())
            {
                object[] attrs = fi.GetCustomAttributes (typeof(DescriptionAttribute), true);

                if (attrs.Length > 0)
                {
                    foreach (DescriptionAttribute attr in attrs)
                    {
                        if (attr.Description.Equals(description))
                            return (T)fi.GetValue(null);
                    }
                }
            }

            return default(T);
        }

    }
}
