using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class FallDeathTrigger : MonoBehaviour
{
	private PanelReference<Panel_Loading> m_Loading;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerEnter(Collider c)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public FallDeathTrigger()
	{
	}
}
