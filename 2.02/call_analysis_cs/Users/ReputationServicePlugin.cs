using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;
using UnityPlugin;

namespace Users;

public class ReputationServicePlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool ReputationService_SubmitReputationFeedbackAsync(int requestingUserId, string xboxUserId, ReputationFeedbackType reputationFeedbackType, string sessionName, string reasonMessage, string evidenceResourceId, GenericActionCallback callback, IntPtr userData);

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ReputationServicePlugin()
	{
	}
}
