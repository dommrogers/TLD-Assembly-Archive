using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class FallDeathTrigger : MonoBehaviour
{
	private PanelReference<Panel_Loading> m_Loading;

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public FallDeathTrigger()
	{
	}
}
