using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

public class uConsoleCommandParameterSet
{
	public List<string> m_Commands;

	public List<string> m_AllowedParameters;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public uConsoleCommandParameterSet()
	{
	}
}
