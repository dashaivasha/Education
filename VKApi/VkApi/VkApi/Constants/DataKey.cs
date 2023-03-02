using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace VkApi.Constants
{
    public static class Keys
    {
        public enum DataKey
        {
            [Description("Url")]
            Url,
            [Description("Login")]
            Login,
            [Description("Password")]
            Password,
            [Description("Access_token")]
            Access_token,
            [Description("ApiVkVersion")]
            ApiVkVersion,
            [Description("ApiAddress")]
            ApiAddress,
            [Description("RandomStringLength")]
            RandomStringLength,
            [Description("owner_id")]
            owner_id,
            [Description("PostPhoto")]
            PostPhoto,
            [Description("ObjectType")]
            ObjectType
        }

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
