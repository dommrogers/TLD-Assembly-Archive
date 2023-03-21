using Cpp2ILInjected.CallAnalysis;
using Unity.Cloud.UserReporting.Client;

namespace Unity.Cloud.UserReporting.Plugin;

public static class UnityUserReporting
{
	private static UserReportingClient currentClient;

	public static UserReportingClient CurrentClient
	{
		[CalledBy(Type = typeof(UserReportingScriptNoPanel), Member = "Awake")]
		[CalledBy(Type = typeof(UserReportingScriptNoPanel), Member = "OnEnable")]
		[CalledBy(TypeFullName = "UserReportingScriptNoPanel.TLDUserReportingUpdater", Member = "MoveNext")]
		[CalledBy(Type = typeof(InternalUserReport), Member = "Send")]
		[CalledBy(Type = typeof(InternalUserReport), Member = "SubmitUserReport")]
		[CalledBy(Type = typeof(UserReportingConfigureOnly), Member = "Start")]
		[CalledBy(Type = typeof(UserReportingMonitor), Member = "Start")]
		[CalledBy(Type = typeof(UserReportingMonitor), Member = "Trigger")]
		[CalledBy(Type = typeof(UserReportingMonitor), Member = "<Trigger>b__7_2")]
		[CalledBy(Type = typeof(UserReportingScript), Member = "CreateUserReport")]
		[CalledBy(Type = typeof(UserReportingScript), Member = "Start")]
		[CalledBy(Type = typeof(UserReportingScript), Member = "SubmitUserReport")]
		[CalledBy(Type = typeof(UserReportingScript), Member = "Update")]
		[CalledBy(Type = typeof(UnityUserReportingUpdater), Member = "MoveNext")]
		[CallerCount(Count = 26)]
		[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(UserReportingScript), Member = "Start")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UserReportingClient), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static void Configure(string endpoint, string projectIdentifier, IUserReportingPlatform platform, UserReportingClientConfiguration configuration)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityUserReporting), Member = "GetPlatform")]
	[Calls(Type = typeof(UserReportingClient), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static void Configure(string endpoint, string projectIdentifier, UserReportingClientConfiguration configuration)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityUserReporting), Member = "GetPlatform")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Configure(string projectIdentifier, UserReportingClientConfiguration configuration)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityUserReporting), Member = "GetPlatform")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public static void Configure(string projectIdentifier)
	{
	}

	[CalledBy(Type = typeof(UserReportingScriptNoPanel), Member = "Awake")]
	[CalledBy(Type = typeof(UserReportingConfigureOnly), Member = "Start")]
	[CalledBy(Type = typeof(UserReportingMonitor), Member = "Start")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityUserReporting), Member = "GetPlatform")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void Configure()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityUserReporting), Member = "GetPlatform")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void Configure(UserReportingClientConfiguration configuration)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Configure(string projectIdentifier, IUserReportingPlatform platform, UserReportingClientConfiguration configuration)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void Configure(IUserReportingPlatform platform, UserReportingClientConfiguration configuration)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void Configure(IUserReportingPlatform platform)
	{
	}

	[CalledBy(Type = typeof(UserReportingScript), Member = "Start")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityUserReportingPlatform), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private static IUserReportingPlatform GetPlatform()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Use(UserReportingClient client)
	{
	}
}
