using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Gameplay.Condition;

public class InsomniaSaveDataProxy
{
	public List<InsomniaParamsSaveDataProxy> m_ListOfParamData;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public InsomniaSaveDataProxy()
	{
	}
}
