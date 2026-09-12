namespace CSharpCoreConcepts.Concepts.Extensions;

public static class ExtentionMembers
{
    public static bool IsPalindrome(this string s) => s.Reverse().SequenceEqual(s.Reverse());
}