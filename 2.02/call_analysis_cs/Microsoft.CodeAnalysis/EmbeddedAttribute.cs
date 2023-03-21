using System;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.CodeAnalysis;

internal sealed class EmbeddedAttribute : Attribute
{
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public EmbeddedAttribute()
	{
	}
}
