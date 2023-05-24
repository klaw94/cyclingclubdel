using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FieldValidationAPI
{
    public delegate bool RequiredValidDel(string fieldVal);
    public delegate bool RequiredLengthValidDel(string fieldVal, int min, int max);
    public delegate bool DateValidDel(string fieldVal, out DateTime validDate);
    public delegate bool PatternMatchDel(string fieldVal, string pattern);
    public delegate bool CompareFieldsValidDel(string fieldVal, string fieldValCompare);
    public class CommonFieldValidatorFunction
    {
        private static RequiredValidDel _requiredValidDel = null;
        private static RequiredLengthValidDel _requiredLengthValidDel = null;
        private static DateValidDel _dateValidDel = null;
        private static PatternMatchDel _patternMatchDel = null;
        private static CompareFieldsValidDel _compareFieldsValidDel = null;

        //To Esxpose our delegate object to calling code we create a read only property
        public static RequiredValidDel RequiredFiledValidDel
        {
            get 
            { 
                if(_requiredValidDel == null)
                {
                    _requiredValidDel = new RequiredValidDel(RequiredFieldValid);
                }
                return _requiredValidDel;
            }
        }

        public static RequiredLengthValidDel RequiredLengthValidDel
        {
            get
            {
                if (_requiredLengthValidDel == null)
                {
                    _requiredLengthValidDel = new RequiredLengthValidDel(RequiredLengthValid);
                }
                return _requiredLengthValidDel;
            }
        }

        public static DateValidDel DateValidDel
        {
            get
            {
                if (_dateValidDel == null)
                {
                    _dateValidDel = new DateValidDel(DateValid);
                }
                return _dateValidDel;
            }
        }

        public static PatternMatchDel PatternMatchDel
        {
            get
            {
                if (_patternMatchDel == null)
                {
                    _patternMatchDel = new PatternMatchDel(FieldPatternValid);
                }
                return _patternMatchDel;
            }
        }

        public static CompareFieldsValidDel CompareFieldsValidDel
        {
            get
            {
                if (_compareFieldsValidDel == null)
                {
                    _compareFieldsValidDel = new CompareFieldsValidDel(FieldComparisonValid);
                }
                return _compareFieldsValidDel;
            }
        }


        private static bool RequiredFieldValid(string fieldVal)
        {
            return !string.IsNullOrEmpty(fieldVal);
        }

        private static bool RequiredLengthValid(string fieldName, int min, int max)
        {
            return fieldName.Length >= min && fieldName.Length <= max;
        }

        private static bool DateValid(string fieldVal, out DateTime validDateTime)
        {
            return DateTime.TryParse(fieldVal, out validDateTime);
        }

        private static bool FieldPatternValid(string fieldVal, string regularExpressionPattern)
        {
            Regex regex = new Regex(regularExpressionPattern);
            return regex.IsMatch(fieldVal);
        }

        private static bool FieldComparisonValid(string field1, string field2)
        {
            return field1.Equals(field2);
        }


    }
}
