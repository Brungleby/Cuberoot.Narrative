
/** NarrativeNodeGraphData.cs
*
*	Created by LIAM WOFFORD of CUBEROOT SOFTWARE, LLC.
*
*	Free to use or modify, with or without creditation,
*	under the Creative Commons 0 License.
*/

#region Includes

using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using Cuberoot.Editor;

#endregion

namespace Cuberoot.Narrative
{
	/// <summary>
	/// __TODO_ANNOTATE__
	///</summary>
	[System.Serializable]
	[CreateAssetMenu(menuName = "Cuberoot/Narrative/Narrative Data", fileName = "New Narrative Data")]

	public sealed class NarrativeNodeGraphData :
	CustomNodeGraphData
	{
		#region Data

		#region



		#endregion

		#endregion
		#region Methods

		#region

		public override System.Type[] UsableEditorTypes =>
			new System.Type[] { typeof(NarrativeNodeGraph) };

		#endregion

		#endregion
	}
}
