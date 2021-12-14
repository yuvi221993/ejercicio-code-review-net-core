using System;
using System.ComponentModel.DataAnnotations;

namespace Calculadora.Notations
{
	 public class TitleToExport : ValidationAttribute
    {
        public readonly string Title;

        public readonly Type FormatType;

//No empty constructor
        public TitleToExport() { }

        public TitleToExport(string title) => Title = title;
//no commented codes
        // public TitleToExport(string title, Type formatType)
        // {
        //     Title = title;
        //     FormatType = formatType;
        // }
    }
}
