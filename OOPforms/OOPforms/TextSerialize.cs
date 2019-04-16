using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace OOPforms
{
   public class TextSerialize
    {
        public BindingList<Company> TCompany { get; set; }
        public BindingList<Owner> TOwner { get; set; }
        private List<Object> list;
        public static TextSerialize text;
        public static void CreateText()
        {
            text = new TextSerialize();
            
        }

        public static void SaveText()
        {
            text.list.Add(text.TCompany);
            text.list.Add(text.TOwner);
            List<String> arrayInfo = new List<string>();
            foreach(var prop in text.GetType().GetProperties())
            {
                Type myListElementType = text.TCompany.GetType().GetGenericArguments().Single();
                PropertyInfo[] myPropertyInfo = myListElementType.GetProperties();
                String str = myListElementType.ToString() + "[";
                var last2 = text.TCompany.Last();
                foreach (Object member in text.TCompany)
                {
                    FieldInfo[] fields = member.GetType().GetFields(BindingFlags.Public |
                                                  BindingFlags.NonPublic |
                                                  BindingFlags.Instance);
                    var last = fields.Last();
                    str += "{";
                    foreach (FieldInfo f in fields)
                    {
                        str += f.Name + " = " + f.GetValue(member);
                        if (!f.Equals(last))
                        {
                            str += ",";
                        }

                    }
                    str += "}";
                    if (!member.Equals(last2))
                    {
                        str += ",";
                    }
                }
                str += "]";
                arrayInfo.Add(str);
            }
           
           
         //   MessageBox.Show(str);
            using (FileStream stream = new FileStream("textser.txt", FileMode.Create))
            {
                int size;

                foreach (string s in arrayInfo)
                {
                    size = s.Length;
                    byte[] infoArray = new byte[size];
                    infoArray = System.Text.Encoding.UTF8.GetBytes(s);
                    stream.Write(infoArray, 0, infoArray.Length);
                }
            }
        }


        public static void LoadText()
        {
            
        }
    }
    
}

