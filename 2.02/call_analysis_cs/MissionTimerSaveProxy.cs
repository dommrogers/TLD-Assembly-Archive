using Cpp2ILInjected.CallAnalysis;

public class MissionTimerSaveProxy
{
	public MissionTimerType m_Type;

	public bool m_IsRealtime;

	public bool m_ShowOnHUD;

	public float m_Duration;

	public string m_EventOnExpire;

	public bool m_RemoveOnExpire;

	public bool m_ExpireHandled;

	public float m_ElapsedTime;

	public bool m_AccountsForLoadingTime;

	public string m_StartingTime;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public MissionTimerSaveProxy()
	{
	}
}
