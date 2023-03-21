using Cpp2ILInjected.CallAnalysis;

public class ExperienceModeManagerSaveDataProxy
{
	public ExperienceModeType m_CurrentModeType;

	public string m_CustomModeString;

	public ExperienceModeType m_PreviousModeType;

	[CallerCount(Count = 0)]
	public ExperienceModeManagerSaveDataProxy()
	{
	}
}
