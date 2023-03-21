using Cpp2ILInjected.CallAnalysis;

public class GameManagerSaveDataProxy
{
	public bool m_BlockAbilityToRest;

	public string m_BlockedRestLocID;

	public string m_SceneTransitionDataSerialized;

	public GameRegion m_StartRegion;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public GameManagerSaveDataProxy()
	{
	}
}
