namespace Cpp2ILInjected;

internal static class RefHelper<T>
{
	private static T backingField;

	public static ref T GetSharedReference()
	{
		return ref backingField;
	}
}
