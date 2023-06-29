using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace TLD.Cooking;

public class RecipeBookGameState
{
	public readonly List<string> m_UnlockedRecipes;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RecipeBookGameState()
	{
	}
}
