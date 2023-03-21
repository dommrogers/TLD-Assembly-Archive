namespace UnityPlugin;

public enum MatchStatus
{
	None,
	SubmittingMatchTicket,
	Searching,
	Found,
	Joining,
	WaitingForRemoteClientsToJoin,
	Measuring,
	UploadingQosMeasurements,
	WaitingForRemoteClientsToUploadQos,
	Evaluating,
	Completed,
	Resubmitting,
	Expired,
	Canceling,
	Canceled,
	Failed
}
