namespace UnityPlugin;

public enum MultiplayerSessionChangeTypes
{
	None = 0,
	Everything = 1,
	HostDeviceTokenChange = 2,
	InitializationStateChange = 4,
	MatchmakingStatusChange = 8,
	MemberListChange = 0x10,
	MemberStatusChange = 0x20,
	SessionJoinabilityChange = 0x40,
	CustomPropertyChange = 0x80,
	MemberCustomPropertyChange = 0x100
}
