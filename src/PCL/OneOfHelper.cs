namespace PCL;

internal static class OneOfHelper
{
	public static MeloongCore.OneOf<T1, T2> From<T1, T2>(T1 value)
	{
		return value;
	}
}
