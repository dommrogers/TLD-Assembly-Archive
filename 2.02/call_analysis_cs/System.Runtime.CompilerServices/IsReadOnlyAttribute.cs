using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices;

internal sealed class IsReadOnlyAttribute : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public IsReadOnlyAttribute()
	{
	}
}
