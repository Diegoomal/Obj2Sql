using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Obj2Sql
{
    public static class Util {
        
        public static string[] RecuperaSomentePropriedades(object o) 
        {
            if(o == null) { return new string[] { "NullReferenceException" }; }

            // List<string> list = new List<string>();
            // System.Reflection.PropertyInfo[] props = o.GetType().GetProperties();
            // for (int i = 0; i < props.Length - 1; i++) {
            //     list.Add(props[i].Name);
            // }
            // return list.ToArray();

            return o.GetType().GetProperties().Select(x => x.Name.ToLower()).ToArray();
        }

        public static string[] RecuperaSomenteValores(object o) 
        {
            if(o == null) { return new string[] { "NullReferenceException" }; }

            // List<string> list = new List<string>();
            // System.Reflection.PropertyInfo[] props = Obj.GetType().GetProperties();
            // for (int i = 0; i < props.Length - 1; i++) {
            //     list.Add(props[i].GetValue(Obj).ToString());
            // }
            // return list.ToArray();

            return o.GetType().GetProperties().Select(x => x.GetValue(o).ToString()).ToArray();
        }

        public static string GetOnlyNameOfClass(object o)
        {
            if (o == null) { return "NullReferenceException"; }
            return o.GetType().Name;
        }

        // public override string ToString()
        // {
        //     if(Obj == null) return "NullReferenceException";
        //     StringBuilder sb = new StringBuilder();
        //     System.Reflection.PropertyInfo[] props = Obj.GetType().GetProperties();
        //     for (int i = 0; i < props.Length - 1; i++) {
        //         sb.Append(props[i].Name).Append(": ");
        //         sb.Append(props[i].GetValue(Obj)).Append(": ");
        //         sb.Append(props[i].GetValue(Obj).GetType()).Append(": ");
        //         sb.Append("\n");
        //     }
        //     return sb.ToString();
        // }

    }
}