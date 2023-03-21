using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class NPCDisableConditionUpdateEnforcer : MonoBehaviour
{
	private PanelReference<Panel_Loading> m_Loading;

	[Calls(Type = typeof(BodyCarry), Member = "IsCarryingBody")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public NPCDisableConditionUpdateEnforcer()
	{
	}
}
