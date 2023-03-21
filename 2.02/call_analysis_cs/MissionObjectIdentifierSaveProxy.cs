using Cpp2ILInjected.CallAnalysis;

public class MissionObjectIdentifierSaveProxy
{
	public string m_Id;

	public MissionObjectClass m_ObjectClass;

	public string m_ActivityTags;

	public bool m_DestroyAfterMission;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public MissionObjectIdentifierSaveProxy()
	{
	}
}
