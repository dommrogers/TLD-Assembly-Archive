using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.UI;

public class MiniNavIconMission : MonoBehaviour
{
	private const string m_TalesSpriteName = "ico_TalesObjectives";

	private const string m_MissionsSpriteName = "ico_map_offscreen";

	private PanelReference<Panel_MissionsStory> m_MissionsStory;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "AreTalesAvailable")]
	[CallsUnknownMethods(Count = 1)]
	private bool AreTalesAvailable()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "AreTalesAvailable")]
	[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MiniNavIconMission()
	{
	}
}
