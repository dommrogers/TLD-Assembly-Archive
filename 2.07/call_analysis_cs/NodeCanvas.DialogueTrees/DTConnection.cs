using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.DialogueTrees;

public class DTConnection : Connection
{
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DTConnection()
	{
	}
}
