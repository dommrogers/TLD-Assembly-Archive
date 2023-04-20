using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xbox;
using UnityEngine;
using UnityEngine.UI;

public class UnlockAchievementSampleLogic : MonoBehaviour
{
	public Text output;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gdk), Member = "get_Helpers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void UnlockAchievement()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UnlockAchievementSampleLogic()
	{
	}
}
