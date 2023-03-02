﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace dbtask.Constants
{
    public static class Keys
    {
        public enum DataKey
        {
            [Description("Login")]
            Login,
            [Description("Password")]
            Password,
            [Description("Server")]
            Server,
            [Description("DBName")]
            DBName
        }

        // <summary>
        //method for extracting enum description values
        //</summary>
        public static string GetEnumDescription(this Enum genericEnum)
        {
            var genericEnumType = genericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(genericEnum.ToString());

            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attributes = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attributes != null && attributes.Count() > 0)
                {
                    return ((DescriptionAttribute)attributes.ElementAt(0)).Description;
                }
            }

            return genericEnum.ToString();
        }

    }
}
