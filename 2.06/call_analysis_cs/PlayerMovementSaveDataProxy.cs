using Cpp2ILInjected.CallAnalysis;

public class PlayerMovementSaveDataProxy
{
	public float m_SprintStamina;

	public PlayerMovement.ForcedMovement m_ForcedMovement;

	public bool m_ForceNoSprain;

	public bool m_IsCrouching;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public PlayerMovementSaveDataProxy()
	{
	}
}
