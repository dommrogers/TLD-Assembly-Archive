using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.ClothingTool;

public class ClothingToolHelper : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ClothingToolHelper()
	{
	}
}
