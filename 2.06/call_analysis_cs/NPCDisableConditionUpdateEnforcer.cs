using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class NPCDisableConditionUpdateEnforcer : MonoBehaviour
{
	private PanelReference<Panel_Loading> m_Loading;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BodyCarry), Member = "IsCarryingBody")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 13)]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public NPCDisableConditionUpdateEnforcer()
	{
	}
}
