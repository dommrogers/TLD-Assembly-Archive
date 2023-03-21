namespace UnityPlugin;

public enum MultiplayerEventType
{
	UserAdded,
	UserRemoved,
	MemberJoined,
	MemberLeft,
	MemberPropertyChanged,
	LocalMemberPropertyWriteCompleted,
	LocalMemberConnectionAddressWriteCompleted,
	SessionPropertyChanged,
	SessionPropertyWriteCompleted,
	SessionSynchronizedPropertyWriteCompleted,
	HostChanged,
	SynchronizedHostWriteCompleted,
	JoinabilityStateChanged,
	PerformQosMeasurements,
	FindMatchCompleted,
	JoinGameCompleted,
	LeaveGameCompleted,
	JoinLobbyCompleted,
	ClientDisconnectedFromMultiplayerService,
	InviteSent,
	TournamentRegistrationStateChanged,
	TournamentGameSessionReady,
	ArbitrationComplete
}
