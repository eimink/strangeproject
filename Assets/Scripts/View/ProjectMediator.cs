using System;
using UnityEngine;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;

namespace Project
{
	public class ProjectMediator : EventMediator
	{
		//This is how your Mediator knows about your View.
		[Inject]
		public ProjectView view{ get; set;}
		
		public override void OnRegister()
		{
			//Listen to the view for an event
			view.dispatcher.AddListener(ProjectView.CLICK_EVENT, onViewClicked);
			view.init ();
		}
		
		public override void OnRemove()
		{
			//Clean up listeners when the view is about to be destroyed
			view.dispatcher.RemoveListener(ProjectView.CLICK_EVENT, onViewClicked);
			Debug.Log("Mediator OnRemove");
		}
		
		private void onViewClicked()
		{
			Debug.Log("View click detected");
		}

	}
}

