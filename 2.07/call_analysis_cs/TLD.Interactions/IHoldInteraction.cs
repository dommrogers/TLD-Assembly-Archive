namespace TLD.Interactions;

public interface IHoldInteraction : IInteraction
{
	bool IsActive { get; }

	bool CanCancel { get; }

	float NormalizedProgress { get; }

	bool PerformHold();

	void CancelHold();
}
