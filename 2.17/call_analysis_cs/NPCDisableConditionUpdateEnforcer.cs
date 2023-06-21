using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class NPCDisableConditionUpdateEnforcer : MonoBehaviour
{
	private PanelReference<Panel_Loading> m_Loading;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(NPC), Member = "IsBeingCarried")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public NPCDisableConditionUpdateEnforcer()
	{
	}
}
