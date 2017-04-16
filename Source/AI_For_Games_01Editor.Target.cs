// Heath Parkes 2017

using UnrealBuildTool;
using System.Collections.Generic;

public class AI_For_Games_01EditorTarget : TargetRules
{
	public AI_For_Games_01EditorTarget(TargetInfo Target)
	{
		Type = TargetType.Editor;
	}

	//
	// TargetRules interface.
	//

	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "AI_For_Games_01" } );
	}
}
