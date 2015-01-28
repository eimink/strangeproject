using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;

namespace Project
{
	public class ProjectRoot : ContextView {

		void Awake()
		{
			context = new ProjectContext(this);
		}
	}
}
