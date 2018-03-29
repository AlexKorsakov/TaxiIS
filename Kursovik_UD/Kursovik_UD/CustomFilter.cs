using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kursovik_UD
{
    struct FilterPair
    {
        public String field;
        public Object value;
        public String condition;
        public bool isStr;

        public FilterPair(String f, Object v, String cond = "LIKE", bool str = true)
        {
            field = f;
            value = v;
            condition = cond;
            isStr = str;
        }
    }

    class CustomFilter
    {
        List<FilterPair> fields = new List<FilterPair>();
        public CustomFilter(params FilterPair[] f)
        {
            fields.AddRange(f);
        }

        public String createFilter()
        {
            List<String> newFilter = new List<String>();
            foreach (FilterPair pair in fields)
                if (pair.value.ToString() != "")
                    if (pair.isStr)
                        newFilter.Add(String.Format(pair.field + " " + pair.condition + " '%{0}%'", pair.value.ToString().Trim()));
                    else
                        newFilter.Add(String.Format(pair.field + " " + pair.condition + " {0}", pair.value));

            if (newFilter.Count > 0)
                return String.Join(" AND ", newFilter.ToArray());
            return null;
        }
    }
}
