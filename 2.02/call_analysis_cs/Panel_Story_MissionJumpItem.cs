using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Panel_Story_MissionJumpItem : MonoBehaviour
{
	public UILabel m_Label_Mission;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Panel_Story_MissionJumpItem()
	{
	}
}
