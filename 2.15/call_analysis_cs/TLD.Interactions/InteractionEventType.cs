namespace TLD.Interactions;

public enum InteractionEventType
{
	InitializeInteraction = 0,
	UpdateInteraction = 1,
	PerformInteraction = 2,
	HideInteraction = 3,
	HoldBegin = 10,
	HoldCancelled = 11,
	HoldEnd = 12,
	OpenBegin = 20,
	OpenEnd = 21,
	CloseBegin = 22,
	CloseEnd = 23
}
