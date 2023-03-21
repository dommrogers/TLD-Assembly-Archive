using Cpp2ILInjected.CallAnalysis;

public class PlayerMovementSaveDataProxy
{
	public float m_SprintStamina;

	public PlayerMovement.ForcedMovement m_ForcedMovement;

	public bool m_ForceNoSprain;

	public bool m_IsCrouching;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PlayerMovementSaveDataProxy()
	{
	}
}
