using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Switch;

public class SwitchBootUpdate : MonoBehaviour
{
	private UILabel m_Label_Continue;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SwitchBootUpdate()
	{
	}
}
