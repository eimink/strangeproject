using UnityEngine;
using System.Collections;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.dispatcher.eventdispatcher.impl;

namespace Project
{
	public class ProjectContext : MVCSContext {

		public ProjectContext (MonoBehaviour view) : base(view)
		{
		}

		public ProjectContext (MonoBehaviour view, ContextStartupFlags flags) : base(view, flags)
		{
		}
		
		protected override void mapBindings()
		{
			// Injector, mediator and command bindings go here
		}
	}
}
