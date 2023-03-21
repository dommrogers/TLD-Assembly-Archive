using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Switch;

public class SwitchBootUpdate : MonoBehaviour
{
	private UILabel m_Label_Continue;

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SwitchBootUpdate()
	{
	}
}
