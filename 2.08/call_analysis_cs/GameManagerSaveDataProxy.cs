using Cpp2ILInjected.CallAnalysis;

public class GameManagerSaveDataProxy
{
	public bool m_BlockAbilityToRest;

	public string m_BlockedRestLocID;

	public string m_SceneTransitionDataSerialized;

	public string m_StartRegion;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public GameManagerSaveDataProxy()
	{
	}
}
