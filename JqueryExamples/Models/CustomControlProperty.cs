using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JqueryExamples.Models
{
    public class CustomControlProperty
    {
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
        public int FieldLength { get; set; }
        public bool IsActive { get; set; }
        public string FieldType { get; set; }
        public string ReadOnlyProp { get; set; }
    }

    public class Genderdet
    {
        public int id { get; set; }
        public string Gender { get; set; }
    }

    public class Designationdet
    {
        public int id { get; set; }
        public string Designation { get; set; }
    }
}