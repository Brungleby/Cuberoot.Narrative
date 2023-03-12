
/** NarrativeNodeGraph.cs
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
using UnityEngine.UIElements;

using UnityEditor;
using UnityEditor.UIElements;
using UnityEditor.Experimental.GraphView;

using Cuberoot.Editor;

#endregion

namespace Cuberoot.Narrative
{
	/// <summary>
	/// __TODO_ANNOTATE__
	///</summary>

	public sealed class NarrativeNodeGraph : CustomNodeGraph<NarrativeNodeGraphView, NarrativeNodeGraphData>
	{
		#region Data

		#region



		#endregion

		#endregion
		#region Methods

		#region

		protected override void InitializeToolbar(Toolbar toolbar)
		{
			base.InitializeToolbar(toolbar);

			toolbar.Add(new Button(() => { graph.CreateNewNode<NarrativeNode>(); }));
		}

		#endregion

		#endregion
	}
}
