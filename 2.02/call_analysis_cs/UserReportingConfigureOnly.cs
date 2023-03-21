using Cpp2ILInjected.CallAnalysis;
using Unity.Cloud.UserReporting.Plugin;
using UnityEngine;

public class UserReportingConfigureOnly : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	private void Start()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UserReportingConfigureOnly()
	{
	}
}
