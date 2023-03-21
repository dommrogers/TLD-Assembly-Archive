using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace Epic.OnlineServices.Achievements;

[StructLayout(0, Pack = 8, Size = 40)]
internal struct QueryDefinitionsOptionsInternal : ISettable, IDisposable
{
	private int m_ApiVersion;

	private IntPtr m_LocalUserId;

	private IntPtr m_EpicUserId_DEPRECATED;

	private IntPtr m_HiddenAchievementIds_DEPRECATED;

	private uint m_HiddenAchievementsCount_DEPRECATED;

	public ProductUserId LocalUserId
	{
		[CalledBy(Type = typeof(QueryDefinitionsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryDefinitionsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public EpicAccountId EpicUserId_DEPRECATED
	{
		[CalledBy(Type = typeof(QueryDefinitionsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryDefinitionsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Helper), Member = "TryMarshalSet")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public string[] HiddenAchievementIds_DEPRECATED
	{
		[CalledBy(Type = typeof(QueryDefinitionsOptionsInternal), Member = "Set")]
		[CalledBy(Type = typeof(QueryDefinitionsOptionsInternal), Member = "Set")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QueryDefinitionsOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryDefinitionsOptionsInternal), Member = "set_EpicUserId_DEPRECATED")]
	[Calls(Type = typeof(QueryDefinitionsOptionsInternal), Member = "set_HiddenAchievementIds_DEPRECATED")]
	public void Set(QueryDefinitionsOptions other)
	{
	}

	[CalledBy(Type = typeof(AchievementsInterface), Member = "QueryDefinitions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QueryDefinitionsOptionsInternal), Member = "set_LocalUserId")]
	[Calls(Type = typeof(QueryDefinitionsOptionsInternal), Member = "set_EpicUserId_DEPRECATED")]
	[Calls(Type = typeof(QueryDefinitionsOptionsInternal), Member = "set_HiddenAchievementIds_DEPRECATED")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Set(object other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Helper), Member = "TryMarshalDispose")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Dispose()
	{
	}
}
