namespace CSharpCoreConcepts.Concepts.Extensions;

public static class ExtentionMembers
{
    public static bool IsPalindrome(this string s)
    {
        var reversed = new string(s.Reverse().ToArray());
        return s.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
}