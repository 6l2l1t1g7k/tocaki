using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace tocaki.a3_ErrorsHandler;

public class GeneralException(ErrorsEnum errorCode) : Exception($"{errorCode} : {GetEnumDescription(errorCode)}") {
    public static string GetEnumDescription(Enum value) {
        FieldInfo? fi = value.GetType().GetField(value.ToString());
        DescriptionAttribute? attribute = fi?.GetCustomAttribute(typeof(DescriptionAttribute), false) as DescriptionAttribute;
        return attribute?.Description ?? "Erreur sans description.";
    }
}


