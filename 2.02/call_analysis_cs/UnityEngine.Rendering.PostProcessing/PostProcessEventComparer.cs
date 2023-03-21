using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

[StructLayout(0, Size = 1)]
internal struct PostProcessEventComparer : IEqualityComparer<PostProcessEvent>
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool Equals(PostProcessEvent x, PostProcessEvent y)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetHashCode(PostProcessEvent obj)
	{
		return 0;
	}
}
