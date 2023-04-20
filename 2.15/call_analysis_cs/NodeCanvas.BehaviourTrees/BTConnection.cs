using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.BehaviourTrees;

public class BTConnection : Connection
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BTConnection()
	{
	}
}
