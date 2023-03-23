using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Demo
{
    public static class CongCu
    {
        public static string NormalizeVietnameseString(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            text = text.Normalize(NormalizationForm.FormD);
            var chars = text.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray();
            return new string(chars).Normalize(NormalizationForm.FormC);
        }
    }
}
