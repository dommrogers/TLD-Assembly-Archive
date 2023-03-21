using Cpp2ILInjected.CallAnalysis;
using UnityPlugin;

namespace Users;

public class PermissionIdConstants
{
	private static string m_BroadcastWithTwitch;

	private static string m_CommunicateUsingText;

	private static string m_CommunicateUsingVideo;

	private static string m_CommunicateUsingVoice;

	private static string m_PlayMultiplayer;

	private static string m_ViewTargetExerciseInfo;

	private static string m_ViewTargetGameHistory;

	private static string m_ViewTargetMusicHistory;

	private static string m_ViewTargetMusicStatus;

	private static string m_ViewTargetPresence;

	private static string m_ViewTargetProfile;

	private static string m_ViewTargetVideoHistory;

	private static string m_ViewTargetVideoStatus;

	public static string BroadcastWithTwitch
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public static string CommunicateUsingText
	{
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public static string CommunicateUsingVideo
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public static string CommunicateUsingVoice
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public static string PlayMultiplayer
	{
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public static string ViewTargetExerciseInfo
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public static string ViewTargetGameHistory
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public static string ViewTargetMusicHistory
	{
		[CallsUnknownMethods(Count = 6)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public static string ViewTargetMusicStatus
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public static string ViewTargetPresence
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public static string ViewTargetProfile
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		get
		{
			return null;
		}
	}

	public static string ViewTargetVideoHistory
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public static string ViewTargetVideoStatus
	{
		[Calls(Type = typeof(UnityPlugin.Utils), Member = "MarshalCachedString")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public PermissionIdConstants()
	{
	}
}
