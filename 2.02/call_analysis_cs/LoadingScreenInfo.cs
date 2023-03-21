using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LoadingScreenInfo
{
	public List<AsyncOperation> m_AsyncOperations;

	public string m_MainScene;

	public string m_Region;

	public string m_Mission;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public LoadingScreenInfo()
	{
	}
}
