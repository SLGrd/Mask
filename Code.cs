using System;

namespace Mask;
public static class ExtensionMethods
{
    public static string ToMask(this string t, string mask)
    {
        int n = 0;
        char[] s = mask.ToCharArray();

        for (int i = 0; i < mask.Length; i++)
            if (mask[i] == '_')
                if (n < t.Length) s[i] = t[n++]; else break;

        return new(s);
    }
}