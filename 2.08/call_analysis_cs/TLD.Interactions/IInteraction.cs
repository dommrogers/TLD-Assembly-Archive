using UnityEngine;

namespace TLD.Interactions;

public interface IInteraction
{
	string HoverText { get; }

	bool IsEnabled { get; }

	bool CanInteract { get; }

	void InitializeInteraction();

	void UpdateInteraction();

	bool PerformInteraction();

	void HideInteraction();

	GameObject GetInteractiveObject();
}
