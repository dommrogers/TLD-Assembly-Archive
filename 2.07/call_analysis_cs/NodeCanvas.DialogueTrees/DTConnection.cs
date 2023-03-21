using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.DialogueTrees;

public class DTConnection : Connection
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public DTConnection()
	{
	}
}
