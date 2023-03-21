using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.BehaviourTrees;

public class BTConnection : Connection
{
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BTConnection()
	{
	}
}
